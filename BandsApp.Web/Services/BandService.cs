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
            new Band { Id = 2, Name = "Band 2", Description = "Description 2" },
            new Band { Id = 3, Name = "Band 3", Description = "Description 3" },
            new Band { Id = 3, Name = "Band 3", Description = "Description 3" }
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
