using OOPAssign4Sol.Part02___Q03;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssign4Sol.Part02___Q02
{ 
    class BasicAuthenticationService : IAuthenticationService
    {
        string CredentialName = "Somaya";
        string CredentialPass = "123456";
        string role = "Admin" ;
        public bool AuthenticateUser(string Name, string Password)
        {

            if (Name == CredentialName && Password == CredentialPass)
                return true;
            else
                return false;
        }

        public bool AuthorizeUser(string Name)
        {
            if (Name == CredentialName && role != null)
            {
                return true;
            }
            else return false;
        }
    }
}
