using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountDTO
    {
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }
        public AccountDTO()
        {

        }
        public AccountDTO(string userName, string displayName, string password, int type)
        {
            UserName = userName;
            DisplayName = displayName;
            Password = password;
            Type = type;
        }
    }


}
