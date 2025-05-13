using BandsApp.Web.Models;
namespace BandsApp.Web.Services;

public class BandService
{
    private readonly List<Band> _bands;
    public BandService()
    {
        _bands = new List<Band>
        {   // ~/Img/20250218_disturbedpress_1.webp
            new Band { Id = 1, ImageUrl="20250218_disturbedpress_1.webp", Name = "Disturbed", VideoUrl="8nW-IPrzM1g",
                Description = "Disturbed är ett amerikanskt metalband som grundades 1994 under namnet Brawl av Dan Donegan, Steve \"Fuzz\" Kmak, Mike Wengren och Erich Awalt i Chicago, Illinois. David Draiman övertog som sångare 1996 och bandet bytte namn till Disturbed. Sedan bandet grundades har de sålt över 10 miljoner album och även hunnit spela med stora namn som Pendulum Garden och Burning Machine. " 
            , Album = new string[] { "The Sickness", "Believe", "Ten Thousand Fists", "Indestructible", "Asylum", "Immortalized" }
            },
            new Band { Id = 2, ImageUrl="guns-n-roses-at-uic-pavillion-chicago-illinois-august-21-1987.webp", Name = "Guns n Roses", VideoUrl="1w7OgIMMRc4",
                Description = "Guns N' Roses[a] is an American hard rock band formed in Los Angeles, California in 1985 as a merger of local bands L.A. Guns and Hollywood Rose."
            , Album = new string[] { "Appetite for Destruction", "Use Your Illusion I", "Use Your Illusion II", "Chinese Democracy" }
            },
            new Band { Id = 3, ImageUrl="Sabaton.jpg", Name = "Sabaton", VideoUrl="gtbbIB776ks",
                Description = "Sabaton is a Swedish power metal band from Falun. The band was formed in 1999. The vast majority of their songs are about historical events, mainly wars and significant battles." 
            ,Album = new string[] { "Metalizer", "Primo Victoria", "Attero Dominatus", "The Art of War", "Coat of Arms", "Heroes" }
            },
            new Band { Id = 4, ImageUrl="61bf384bbb1f2f4a8021d112_opengraph copy.jpg", Name = "Nightwish", VideoUrl="hTdhXxxWREo",
                Description = "Nightwish är ett symfoniskt metalband från Kitee, Finland, grundat 1996 av Tuomas Holopainen, Emppu Vuorinen och Tarja Turunen. Bandet blev snabbt känt för sin unika kombination av opera-liknande sång och metal. De har släppt flera kritikerrosade album och turnerat världen över. Nightwish räknas som ett av de mest framgångsrika banden inom sin genre."
            ,Album = new string[] { "Angels Fall First", "Oceanborn", "Wishmaster", "Century Child", "Once", "Dark Passion Play" }
            }
        };
    }
    public Band[] GetAllBands()
    {
        return _bands.ToArray();
    }
    public Band? GetBandById(int id)
    {
        
        return _bands.SingleOrDefault(b => b.Id == id);
    }
}
