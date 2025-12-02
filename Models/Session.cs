using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryEquipmentStore.Models
{
    public static class UserSession
    {
        public static string Role { get; set; }
        public static int CurrentUserId { get; set; }
        public static string CurrentUserEmail { get; set; }
    }
}
