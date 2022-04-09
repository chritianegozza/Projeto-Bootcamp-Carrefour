using System;
using Projeto_Bootcamp_Carrefour.src.Entities;

namespace dotnet__poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight  arthur  = new Knight("Arthur", 23, "Knight");
            //Hero  oponnet = new Hero("Malignus", 33, "Devil");
            Wizard wizard = new Wizard("Morgana", 45, "White Wizard");
           
            Console.WriteLine(arthur.Attack());
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
           
        }
    }
}