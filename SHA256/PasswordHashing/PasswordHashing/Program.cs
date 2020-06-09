using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordHashing
{
    class Program
    {
        static void Main(string[] args)
        {
            string salt = null;

            string hash = null;

            bool check;

            CryptographyProcessor proc = new CryptographyProcessor();

            //salt=proc.CreateSalt(32);

            //hash=proc.GenerateHash("password", "XcQ0tql2NY0NXrQjP+dGHr64gB9VDvEHBS8uOwRwcQ0=");

            check=proc.AreEqual("password", "uHKWLW6/XqUuJuIPlKakVa/RpdRcOYjUchFfQiOYx5M=", "XcQ0tql2NY0NXrQjP+dGHr64gB9VDvEHBS8uOwRwcQ0=");



            Console.WriteLine(check);



            Console.ReadLine();
        }
    }
}
