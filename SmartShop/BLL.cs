using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop
{
    static class BLL
    {
        internal static (bool IsSuccess, int usertype, string Name) Login(string username, string password)
        {
            DAL.UserInfo temp = DAL.User_Get(username);
            if (temp != null && password.Equals(temp.PasswordHash))
                return (true, temp.IsAdmin ? 1 : 0, temp.Name);
            else
                return (false, -1, "");
        }
    }
}
