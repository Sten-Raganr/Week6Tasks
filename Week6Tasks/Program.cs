using System;

namespace Week6Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] superHeroes = { "Batman", "Santa", "Spongebob", "Thor", "Harry Potter" };
            string[] superVillains = { "Godzilla", "Voldemort", "Grinch", "Darth Vader", "T-1000" };
            string[] weapon = { "banana", "fork", "keyboard", "purse", "jar of mud" };
            Random rnd = new Random();
            int random = rnd.Next(0, superHeroes.Length);
            int random1 = rnd.Next(0, superVillains.Length);
            int random2 = rnd.Next(0, weapon.Length);
            Console.WriteLine($"{superHeroes[random]} will fight {superVillains[random1]} with a {weapon[random2]}");
            


            }
        }
}
