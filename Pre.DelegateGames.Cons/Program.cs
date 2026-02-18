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




//methods

/*
 4. Gebruik de delegates met named methods
 */

/*
 5. Gebruik de delegates met lambda methods
 */

/*
 8. Gebruik de generic filter method met predicate
 */

