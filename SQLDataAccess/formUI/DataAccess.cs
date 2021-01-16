using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace formUI
{
   public class DataAccess
    {
        public List<Person> GetPeople(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnVal("Dapper")))
            {
               /* var output = connection.Query<Person>($"select * from Users where lastName='{name}'").ToList();*/
                var output = connection.Query<Person>($"sp_getbylastname @LastName",new { LastName=name}).ToList();
                return output;
            }
        }

        public void InsertUser(string FirstName,string LastName, string EmailAdress,string PhoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnVal("Dapper")))
            {
                Person newPerson = new Person { FirstName= FirstName,LastName=LastName,EmailAdress=EmailAdress,PhoneNumber=PhoneNumber};
                List<Person> people = new List<Person>();
                people.Add(newPerson);
                connection.Execute("sp_insert_user @FirstName, @LastName, @EmailAdress, @PhoneNumber", people);

            }
        }
    }
}
