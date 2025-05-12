using BandsApp.Web.Models;
namespace BandsApp.Web.Services;

public class BandService
{
    private readonly List<Band> _bands;
    public BandService()
    {
        _bands = new List<Band>
        {
            new Band { Id = 1, Name = "Disturbed", Description = "Disturbed är ett amerikanskt metalband som grundades 1994 under namnet Brawl av Dan Donegan, Steve \"Fuzz\" Kmak, Mike Wengren och Erich Awalt i Chicago, Illinois. David Draiman övertog som sångare 1996 och bandet bytte namn till Disturbed. Sedan bandet grundades har de sålt över 10 miljoner album och även hunnit spela med stora namn som Pendulum Garden och Burning Machine. " },
            new Band { Id = 2, Name = "Guns n Roses", Description = "Guns N' Roses[a] is an American hard rock band formed in Los Angeles, California in 1985 as a merger of local bands L.A. Guns and Hollywood Rose." },
            new Band { Id = 3, Name = "Sabaton", Description = "Sabaton is a Swedish power metal band from Falun. The band was formed in 1999. The vast majority of their songs are about historical events, mainly wars and significant battles." },
            new Band { Id = 4, Name = "Band 3", Description = "Description 3" }
        };
    }
    public Band[] GetAllBands()
    {
        return _bands.ToArray();
    }
    public Band? GetBandById(int id)
    {
        return _bands.FirstOrDefault(b => b.Id == id);
    }
}
