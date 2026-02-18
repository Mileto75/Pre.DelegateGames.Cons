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
//use lambdas
gamesFilter.OnSearchGames = (games, search ) =>
{
    var gamesResults = new List<Game>();
    foreach (var game in games)
    {
        if (game.Title.ToLower().Contains(search.ToLower()))
            gamesResults.Add(game);
    }
    //return gamesResults
    return gamesResults;
};
//call the delegate type property/method
var results = gamesFilter.FilterGames(games, "The");
Console.WriteLine("-----------Results by action------------");
foreach(var game in results)
{
    Console.WriteLine(game.Title);
}
//search by genre
gamesFilter.OnSearchGames = (games, search) =>
{
    var gamesResults = new List<Game>();
    foreach (var game in games)
    {
        if (game.Genre.ToLower().Contains(search.ToLower()))
            gamesResults.Add(game);
    }
    //return gamesResults
    return gamesResults;
};
results = gamesFilter.FilterGames(games, "Action");
Console.WriteLine("-----------Results by genre------------");
foreach (var game in results)
{
    Console.WriteLine(game.Title);
}
//methods

/*
 4. Gebruik de delegates met named methods
 */
//search games by title
/*
 5. Gebruik de delegates met lambda methods
 */

/*
 8. Gebruik de generic filter method met predicate
 */

