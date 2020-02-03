using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Forest.Services.IService;
using Forest.Data.BEANS;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

// http://webteach_net.hallam.shu.ac.uk/b7040746/ForestWebService.asmx
public class ForestWebService : System.Web.Services.WebService
{
    public AuthenticationHeader _authenticationHeader;

    private Forest.Services.IService.IMusicService _musicService;

    public ForestWebService()
    {
        _musicService = new Forest.Services.Service.MusicService();        
    }

    [WebMethod, System.Web.Services.Protocols.SoapHeader("_authenticationHeader")]
    public List<MusicBEAN> GetMusicRecordings(int genre)
    {
        //return _musicService.GetMusicRecordings(genre).ToList();
        if (_authenticationHeader.username == "test" & _authenticationHeader.password == "pass")
        {
            try
            {      
            return _musicService.GetMusicRecordings(genre).ToList();
            }
            catch
            {
                throw new Exception("Errorr communicating with web service!");
            }
        }
        else
        {
            throw new Exception("Failed to authenticate with web service");
        }

    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

}
