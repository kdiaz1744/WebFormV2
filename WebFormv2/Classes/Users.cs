using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebFormv2.Classes
{
    [Serializable]
    [DataContract(Name = "User", Namespace = "WebFormv2.Classes")]
    public class Users
    {
        [DataMember(Name = "UserID")]
        public int UserID { get; set; }

        [DataMember(Name = "UserName")]
        public string UserName { get; set; }

        [DataMember(Name = "FirstName")]
        public string FirstName { get; set; }

        [DataMember(Name = "LastName")]
        public string LastName { get; set; }

        [DataMember(Name = "Email")]
        public string Email { get; set; }

        [DataMember(Name = "Adress")]
        public string Adress { get; set; }

        [DataMember(Name = "City")]
        public string City { get; set; }

        [DataMember(Name = "State")]
        public string State { get; set; }

        [DataMember(Name = "ZipCode")]
        public string ZipCode { get; set; }

        [DataMember(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }

        //Foreign Key variables
        [DataMember(Name = "RoleID")]
        public int RoleID { get; set; }

        [DataMember(Name = "StatusID")]
        public int StatusID { get; set; }

        [DataMember(Name = "PictureID")]
        public int PictureID { get; set; }

        [DataMember(Name = "Password")]
        public string Password { get; set; }

        [DataMember(Name = "Initial")]
        public bool Initial { get; set; }


        //This string is just meant to catch if an error was found
        public string Ex { get; set; }


    }
}