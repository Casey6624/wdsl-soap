using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Forest.Services.IService;
using Forest.Data.BEANS;

/// <summary>
/// Summary description for ForestWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class ForestWebService : System.Web.Services.WebService
{
    private Forest.Services.IService.IMusicService _musicService;

    public ForestWebService()
    {
        _musicService = new Forest.Services.Service.MusicService();        
    }

    [WebMethod]
    public List<MusicBEAN> GetMusicRecordings(int genre)
    {
        return _musicService.GetMusicRecordings(genre).ToList();
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

}
