using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using BehComponents;

namespace EmployeeTraffix
{

    class SQLiteInterface
    {

        const string CONNECTION_STRING = "Data Source=database.db;Version=3;New=True;Compress=True;datetimeformat=CurrentCulture";
        const string TRAFFIX_TABLE = "traffix", EMPLOYEES_TABLE = "employees";
        public static string[] TRAFFIX_COLUMNS_EN = { "name", "entrace", "exit", "absenceType", "date", "employeeID" };
        public static string[] TRAFFIX_COLUMNS_FA = { "نام", "ورود", "خروج", "مرخصی", "تاریخ", "شناسه شخص" };

        private static SQLiteInterface database = new SQLiteInterface();
        SQLiteConnection connection;

        public static SQLiteInterface Database { get { return SQLiteInterface.database; } }

        public SQLiteCommand NewCommand(string text)
        {
            this.connection = new SQLiteConnection(CONNECTION_STRING);
            this.connection.Open();
            if (this.connection.State != ConnectionState.Open)
                throw new DatabaseOutOfReachException();
            SQLiteCommand cmd = new SQLiteCommand(text);
            cmd.Connection = this.connection;
            return cmd;
        }

        private void AlterOldTables()
        {
            try
            {
                // no changes for now

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CreateTableIfDoesntExist() 
        {
            try
            {
                NewCommand(
                    string.Format("CREATE TABLE {0} (id INTEGER PRIMARY KEY AUTOINCREMENT, {1} TEXT PRIMARY KEY)",
                    EMPLOYEES_TABLE, TRAFFIX_COLUMNS_EN[0])
                ).ExecuteNonQuery();
                this.connection.Close();
                Console.WriteLine("Table {0} created!", EMPLOYEES_TABLE);

            }
            catch (SQLiteException ex) 
            {
                Console.WriteLine(ex.Message);
                // make sure new fields (phonenumber and targetUnit) are added to the database.
                //AlterOldTables();
            }
            try
            {
                NewCommand(
                    string.Format("CREATE TABLE {0} (id INTEGER PRIMARY KEY AUTOINCREMENT,"
                        + "{1} TEXT NOT NULL, {2} TEXT, {3} TEXT, {4} TEXT, {5} TEXT NOT NULL, " + 
                        "{6} INTEGER NOT NULL, FOREIGN KEY({6}) REFERENCES {7}(id))", TRAFFIX_TABLE, TRAFFIX_COLUMNS_EN[0],
                        TRAFFIX_COLUMNS_EN[1], TRAFFIX_COLUMNS_EN[2], TRAFFIX_COLUMNS_EN[3],
                        TRAFFIX_COLUMNS_EN[4], TRAFFIX_COLUMNS_EN[5], EMPLOYEES_TABLE)
                ).ExecuteNonQuery();
                this.connection.Close();
                Console.WriteLine("Table {0} created!", TRAFFIX_TABLE);

            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
                // make sure new fields (phonenumber and targetUnit) are added to the database.
                //AlterOldTables();
            }
        }

        private SQLiteInterface()
        {
            try
            {
                this.CreateTableIfDoesntExist();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

        }

        public void AddEmployee(string name)
        {
            NewCommand(
                string.Format("INSERT INTO `{0}` ({1}) VALUES ('{2}')", EMPLOYEES_TABLE, TRAFFIX_COLUMNS_EN[0], name)
            ).ExecuteNonQuery();
            this.connection.Close();
        }

        public DataRow DeclareTraffic(int id, string name, PersianDateTime date)
        {
            DataRow traffic = this.FetchTraffic(id, date);
            if (traffic == null)
            {
                NewCommand(
                    string.Format("INSERT INTO `{0}` ({1}, {2}, {3}) VALUES ({4}, '{5}', '{6}')", TRAFFIX_TABLE,  TRAFFIX_COLUMNS_EN[5], 
                    TRAFFIX_COLUMNS_EN[0], TRAFFIX_COLUMNS_EN[4], id, name, DesiredDateFormat(date))
                ).ExecuteNonQuery();
                this.connection.Close();
                
            }
            return traffic;
        }

        public void UpdateTraffic(int id, string name, string value, PersianDateTime date, byte type = 1)
        {
            // type == 1 => set entrance time
            // type == 2 => set exit time
            // type == 3 => set absence type

            this.DeclareTraffic(id, name, date);
            NewCommand(string.Format(
                "UPDATE `{0}` SET {1} = '{2}' WHERE {3} = '{4}' AND {5} = '{6}'",
                    TRAFFIX_TABLE, TRAFFIX_COLUMNS_EN[type], value, TRAFFIX_COLUMNS_EN[5], id,
                    TRAFFIX_COLUMNS_EN[4], DesiredDateFormat(date))
            ).ExecuteNonQuery();
            this.connection.Close();
        }

        public static string DesiredDateFormat(PersianDateTime date)
        {
            return date.ToStringFormat("yyyy/MM/dd");
        }

        public DataRow FetchTraffic(int id, PersianDateTime date)
        {
            SQLiteCommand cmd = NewCommand(
                 string.Format("SELECT * FROM `{0}` WHERE {1} = '{2}' AND {3} = '{4}' LIMIT 1",
                     TRAFFIX_TABLE, TRAFFIX_COLUMNS_EN[5], id,
                     TRAFFIX_COLUMNS_EN[4], DesiredDateFormat(date)
                 )
            );

            DataTable result = new DataTable();
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd.CommandText, this.connection))
            {
                adapter.Fill(result);
                this.connection.Close();
            }

            return result.Rows.Count > 0 ? result.Rows[0] : null;
        }

        public DataTable FetchTraffix(PersianDateTime dateFrom, PersianDateTime dateUntil)
        {
            SQLiteCommand cmd = NewCommand(
                string.Format("SELECT {4},{0},{1},{2},{3} FROM `{5}` WHERE {4} BETWEEN '{6}' AND '{7}' ORDER BY {4},{8}",
                    TRAFFIX_COLUMNS_EN[0], TRAFFIX_COLUMNS_EN[1], TRAFFIX_COLUMNS_EN[2], 
                    TRAFFIX_COLUMNS_EN[3], TRAFFIX_COLUMNS_EN[4], TRAFFIX_TABLE, 
                    DesiredDateFormat(dateFrom), DesiredDateFormat(dateUntil), TRAFFIX_COLUMNS_EN[5]
                )
            );

            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd.CommandText, this.connection))
            {
                DataTable result = new DataTable();
                adapter.Fill(result);
                this.connection.Close();
                return result;
            }
        }
        public DataTable FetchEmployees()
        {
            SQLiteCommand cmd = NewCommand(
                 string.Format("SELECT * FROM `{0}`;", EMPLOYEES_TABLE));

             using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd.CommandText, this.connection))
             {
                 DataTable result = new DataTable();
                 adapter.Fill(result);
                 this.connection.Close();
                 return result;
             }
        }
        public void Save(DataTable newData)
        {
           /* NewCommand(string.Format("DELETE FROM {0}", newData.TableName)).ExecuteNonQuery();
            SQLiteCommand cmd = NewCommand(string.Format("SELECT * from {0}", newData.TableName));
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd.CommandText, this.connection))
            {
                adapter.Update(newData);
            }
            this.connection.Close();*/
        }
    }
}
