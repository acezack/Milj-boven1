using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Miljöboven1.Controller
{
    [Serializable()]
    public class UserList
    {
        #region Variables

        List<User> userList = new List<User>();

        #endregion

        public void AddUser(User user)
        {
            userList.Add(user);
        }

        public void RemoveUser(int index)
        {
            userList.RemoveAt(index);
        }

        public int GetCount()
        {
            return userList.Count();
        }

        public User GetUser(int index)
        {
            return userList[index];
        }

        public string GetUserName(int index)
        {
            return userList[index].UserName;
        }

        public string GetPassword(int index)
        {
            return userList[index].Password;
        }

        public int GetType(int index)
        {
            return userList[index].Type;
        }

        public int GetID(int index)
        {
            return userList[index].ID;
        }

        public void ChangeUserPassword(int index, string newPassword)
        {
            userList[index].Password = newPassword;
        }

        public void ChangeUserUserName(int index, string newUserName)
        {
            userList[index].UserName = newUserName;
        }
    }
}