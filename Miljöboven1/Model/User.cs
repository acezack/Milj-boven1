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

        public String Password { get; set; }

        public Int32 Type { get; set; } //0=admin 
                                        //1=chef
                                        //2=investigator
                                        //3=coordinator

        public Int32 ID { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// This class is a model for the users in the program.
        /// </summary>
        /// <param name="userName">The userName the user uses to login.</param>
        /// <param name="password">The password the user uses to login.</param>
        /// <param name="type">The type of user. (0 = admin, 1 = chef, 2 = investigator, 3 = coordinator)</param>
        /// <param name="id">The ID to recognise the user in the userList. (each user gets an individual ID by the program)</param>
        public User(string userName, string password, int type, int id)
        {
            this.UserName = userName;
            this.Password = password;
            this.Type = type;
            this.ID = id;
        }

        #endregion
    }
}