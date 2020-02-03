using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AuthenticationHeader
/// </summary>
    
public class AuthenticationHeader : System.Web.Services.Protocols.SoapHeader
{

    public string username;
    public string password;

    
    public AuthenticationHeader()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}