using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MilitaryEquipmentStore
{
    internal class DbConfig
    {
        public static MySqlConnection connection = new MySqlConnection("server=localhost;database=WeaponDesktop;Uid=root;Pwd=077604");

        public static void Open()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

        }

        public static void Close()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public static void ExecuteQuery(string query)
        {
            try
            {
                Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                Close();
            }
        }
    }
}
