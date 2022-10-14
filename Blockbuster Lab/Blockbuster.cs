﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster_Lab
{
    public class Blockbuster
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public Blockbuster()
        {
            Movies.Add(new DVD("A Monster Calls", Genre.Drama, 108, new List<string> { "First Tale", "Second Tale", "Third Tale" , "Drown in Your Own Tears"}));
            Movies.Add(new DVD("Die Hard", Genre.Action, 132, new List<string> { "Bruce Willis In Trouble", "Bruce Willis Unalives Some Guys", "Bruce Willis Unalives Alan Rickman, Kind of", "Bruce Willis Reunited with his SO" }));
            Movies.Add(new DVD("The Lord of the Rings Trilogy: Extended Edition", Genre.Action, 682, new List<string> { "The Fellowship of the Ring", "The Two Towers", "The Return of the King" }));
            Movies.Add(new VHS("Galaxy Jam", Genre.Comedy, 70, new List<string> { "Crazy Tunes Challenge the Aliens", "Jichael Mordan Abduction", "The Big Game", "Victory!" }, 0));
            Movies.Add(new VHS("The Mummy w/ Brendan Frasier", Genre.Horror, 125, new List<string> { "The Affair", "Thieves Join Forces with Their Victim", "Oh God That's a Lot of Scarabs", "More Scarabs" }, 0));
            Movies.Add(new VHS("The Princess Bride", Genre.Romance, 98, new List<string> { "As You Wish", "Inconceivable!", "As You Wish 2: Electric Boogaloo", "R.O.A.S. I don't think they exist", "Mostly Dead" ,"Storming the Castle"}, 0));
        }
        
        public void PrintMovies()
        {            
            for(int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"{i}: {Movies[i].Title}");
            }
        }

        public Movie CheckOut()
        {
            PrintMovies();
            Console.WriteLine($"\nWhich movie would you like to watch? Please select from 0 to {Movies.Count-1}");
            int movieIndex = int.Parse(Console.ReadLine());
            
            //Couldn't get Movie.PrintInfo() to call.
            //"An object reference is required for the non-static field, method, or property member."
            Movie movieChoice = Movies.ElementAt(movieIndex);
            Console.WriteLine($"\nTitle: {movieChoice.Title}, Genre: {movieChoice.Category}, Run Time: {movieChoice.RunTime}");
            return movieChoice;

        }
    }
}
