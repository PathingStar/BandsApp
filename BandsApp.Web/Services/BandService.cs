using BandsApp.Web.Models;
namespace BandsApp.Web.Services;

public class BandService
{
    private readonly List<Band> _bands;
    public BandService()
    {
        _bands = new List<Band>
        {
            new Band { Id = 1, Name = "Band 1", Description = "Description 1" },
            new Band { Id = 2, Name = "Band 2", Description = "Description 2" },
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
