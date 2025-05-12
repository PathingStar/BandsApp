﻿using BandsApp.Web.Models;
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
            new Band { Id = 4, Name = "Nightwish", Description = "Nightwish är ett symfoniskt metalband från Kitee, Finland, grundat 1996 av Tuomas Holopainen, Emppu Vuorinen och Tarja Turunen. Bandet blev snabbt känt för sin unika kombination av opera-liknande sång och metal. De har släppt flera kritikerrosade album och turnerat världen över. Nightwish räknas som ett av de mest framgångsrika banden inom sin genre." }
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
