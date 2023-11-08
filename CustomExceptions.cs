using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraffix
{
    class DatabaseOutOfReachException : Exception
    {
        public DatabaseOutOfReachException() : base("اتصال به پایگاه داده با مشکل مواجه شد!") { }
    }
    
    class WrongCredentialsException : Exception
    {
        public WrongCredentialsException() : base("رمز عبور وارد شده اشتباه است!") { }
    }

}
