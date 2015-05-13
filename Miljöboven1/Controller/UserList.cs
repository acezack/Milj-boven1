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

        #region Methods and functions

        // The method to add a user to the userList.
        public void AddUser(User user)
        {
            userList.Add(user);
        }

        // The method to remove a user in the userList.
        public void RemoveUser(int index)
        {
            userList.RemoveAt(index);
        }

        // The function to return the length of the list.
        public int GetCount()
        {
            return userList.Count();
        }

        // The method to return a user from the list.
        public User GetUser(int index)
        {
            return userList[index];
        }

        // The method to return a user's userName from the list.
        public string GetUserName(int index)
        {
            return userList[index].UserName;
        }

        // The method to return a user's password from the list.
        public string GetPassword(int index)
        {
            return userList[index].UserPassword;
        }

        // The method to return the user's userType from the list.
        public int GetType(int index)
        {
            return userList[index].UserType;
        }

        // The method to return the user's ID from the list.
        public int GetID(int index)
        {
            return userList[index].UserID;
        }

        // The method to change a user's password.
        public void ChangeUserPassword(int index, string newPassword)
        {
            userList[index].UserPassword = newPassword;
        }

        // The method to change a user's userName.
        public void ChangeUserUserName(int index, string newUserName)
        {
            userList[index].UserName = newUserName;
        }

        #endregion
    }
}