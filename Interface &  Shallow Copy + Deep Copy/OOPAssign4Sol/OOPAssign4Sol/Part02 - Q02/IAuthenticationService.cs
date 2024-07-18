using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssign4Sol.Part02___Q02
{
    interface IAuthenticationService
    {
        bool AuthenticateUser(string Name, string Password);
        bool AuthorizeUser(string Name);
    }
}
