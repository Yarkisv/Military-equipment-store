using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryEquipmentStore.Models
{
    public class User
    {
        public string Fullname { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }


        public void Update() 
        {
            string query = $"update users set fullname = '{Fullname}', phonenumber = '{Phonenumber}', email_ = '{Email}' where email_ = '{Email}'";

            DbConfig.ExecuteQuery(query);
        }

        public static void ResetPassword(string password, int id) 
        {
            string hashPassword = BCrypt.Net.BCrypt.HashPassword(password);

            string query = $"update users set hashPassword = '{hashPassword}' where id = {id}";

            DbConfig.ExecuteQuery(query); 
        }
    }
}
