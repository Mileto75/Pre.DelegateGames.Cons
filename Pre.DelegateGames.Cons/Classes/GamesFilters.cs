using Pre.DelegateGames.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.DelegateGames.Cons.Classes
{
    /*
     1. Schrijf een delegate waarmee we games kunnen zoeken op titel of Genre
    */
    public delegate IEnumerable<Game> SearchGamesDelegate(IEnumerable<Game> games,string searchString);
    /*
    2. Schrijf een delegate waarmee we de game met de hoogste rating of prijs kunnen ophalen
    */
    public delegate Game SearchGamesByRatingOrPrice(IEnumerable<Game> games, double max);
    /*
     3. Schrijf een delegate waarmee we kunnen controleren of een bepaalde game in de lijst zit(return type bool)
     */
    public delegate bool CheckGamesDelegate(IEnumerable<Game> games, string title);
    /*
    6. vervang de delegates door de logische generic delegate types (Action, Func, Predicate)
    */

    


    //write delegates here
    public class GamesFilters
    {
        //write delegate type properties here
        public SearchGamesDelegate OnSearchGames { get; set; }
        public SearchGamesByRatingOrPrice OnSearchGamesByRatingOrPrice { get; set; }
        public CheckGamesDelegate OnCheckGames { get; set; }

        //define the invoke methods
        public IEnumerable<Game> FilterGames(IEnumerable<Game> games, string search)
        {
            return OnSearchGames.Invoke(games, search);
        }

        /*
        7. Schrijf een algemene filterfunctie die gebruik maakt van een predicate als parameter
        */
    }
}
