// See https://aka.ms/new-console-template for more information
using Pre.DelegateGames.Cons.Classes;
using Pre.DelegateGames.Core.Entities;
using Pre.DelegateGames.Core.Repositories;

Console.WriteLine("Our game database");
var gameRepository = new GameRepository(); //in memory database
var games = gameRepository.GetGames();
foreach(var game in games)
{
    Console.WriteLine(game.Title);
}
//declare filter class
var gamesFilter = new GamesFilters();
//add method to delegate type property
gamesFilter.OnSearchGames = SearchByTitle;


//methods

/*
 4. Gebruik de delegates met named methods
 */
//search games by title
IEnumerable<Game> SearchByTitle(IEnumerable<Game> games, string search)
{
    //search games
    var gamesResults = new List<Game>();
    foreach(var game in games)
    {
        if (game.Title.Contains(search))
            gamesResults.Add(game);
    }
    //return gamesResults
    return gamesResults;
}
/*
 5. Gebruik de delegates met lambda methods
 */

/*
 8. Gebruik de generic filter method met predicate
 */

