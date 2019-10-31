using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RmgAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public Role Roles { get; set; }

        public enum Role
        {
            Admin,
            Competency,
            Toyota,
            BMW,
            EY,
            Delta,
            NT
        }
    }
}
