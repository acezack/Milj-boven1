using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miljöboven1.Controller;

namespace Miljöboven1.Controller
{
    [Serializable()]
    public class User
    {
        #region Variables

        public String UserName { get; set; }

        public String UserPassword { get; set; }

        public Int32 UserType { get; set; } //0=admin 
                                        //1=chef
                                        //2=investigator
                                        //3=coordinator

        public Int32 UserID { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// This class is a model for the users in the program.
        /// </summary>
        /// <param name="userName">The userName the user uses to login.</param>
        /// <param name="userPassword">The password the user uses to login.</param>
        /// <param name="userType">The type of user. (0 = admin, 1 = chef, 2 = investigator, 3 = coordinator)</param>
        /// <param name="userID">The ID to recognise the user in the userList. (each user gets an individual ID by the program)</param>
        public User(string userName, string userPassword, int userType, int userID)
        {
            this.UserName = userName;
            this.UserPassword = userPassword;
            this.UserType = userType;
            this.UserID = userID;
        }

        #endregion
    }
}