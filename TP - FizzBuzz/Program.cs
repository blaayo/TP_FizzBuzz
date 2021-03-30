using System;

namespace TP___FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        { // $"Fichier : {fichier.SetGetUrl}"
            Console.Write($"\n 3, est un multiple de 3 -> {FizzBuzzGame.play(3)}");
            Console.Write($"\n 5, est un multiple de 5 -> {FizzBuzzGame.play(5)}");
            Console.Write($"\n 15, est un multiple de 3 et de 5 -> {FizzBuzzGame.play(5)}");
            Console.Write($"\n 1, aucun des cas précédents, répète le nombre de Alice : {FizzBuzzGame.play(1)}");
        }
    }
}