using System;
using RPG.src.Entities;

namespace RPG
{
    class Program
    {
        static void Main (string[]args)
        {
            Knight hero = new Knight("Eder", 35, "Programador", 100);
            Wizard wizard = new Wizard("Deb", 23, "Mage",100);
            Devil devil = new Devil("Juca", 99, "Devil",1000);
            
            System.Console.WriteLine(devil);
            System.Console.WriteLine(wizard);
            System.Console.WriteLine(hero);
            System.Console.WriteLine(wizard.Attack());
            System.Console.WriteLine(wizard.Attack(8));
            System.Console.WriteLine(hero.Attack());
            System.Console.WriteLine(devil.Defend());
        }
    }   
}