using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryEquipmentStore.Models
{
    public static class UserSession
    {
        public static string FullName { get; set; }
        public static string Email { get; set; }
        public static string Phone { get; set; }
        public static string Role { get; set; }
    }
}
