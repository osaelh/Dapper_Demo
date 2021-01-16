using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formUI
{
    public class Person
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public string PhoneNumber { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{FirstName} {LastName} {EmailAdress} {PhoneNumber}";
            }
        }

        public Person()
        {

        }



    }
}
