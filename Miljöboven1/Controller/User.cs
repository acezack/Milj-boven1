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
        public String UserName { get; set; }

        public String Password { get; set; }

        public Int32 Type { get; set; } //0=admin 
                                        //1=chef
                                        //2=handläggare
                                        //3=miljösamordnare

        public Int32 ID { get; set; }
        
        public User(string userName, string password, int type, int id)
        {
            this.UserName = userName;
            this.Password = password;
            this.Type = type;
            this.ID = id;
        }
    }
}