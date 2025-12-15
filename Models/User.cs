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

        public static void CreateUser(string fullname, string password, string phone, string email, string role = "client") 
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            
            string query = $"insert into users (fullname, hashPassword, phonenumber, email_, role_) values ('{fullname}', '{hashedPassword}', '{phone}', '{email}', '{role}');";

            DbConfig.ExecuteQuery(query);
        }

        public static bool Exists(string email)
        {
            string query = $"SELECT COUNT(*) FROM users WHERE email_ = '{email}'";

            using (var reader = DbConfig.ReadData(query))
            {
                if (reader != null && reader.Read())
                {
                    int count = reader.GetInt32(0);
                    return count > 0;
                }
            }

            return false;
        }

        public static User GetById(int id)
        {
            string query = $"SELECT fullname, email_, phonenumber FROM users WHERE id = {id}";

            using (var reader = DbConfig.ReadData(query))
            {
                if (reader != null && reader.Read())
                {
                    return new User
                    {
                        Fullname = reader["fullname"].ToString(),
                        Email = reader["email_"].ToString(),
                        Phonenumber = reader["phonenumber"].ToString()
                    };
                }
            }

            return null;
        }
    }
}
