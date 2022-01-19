using System;
using Abstracao_Jogo_RPG_em_C.src.Entities;

namespace Abstracao_Jogo_RPG_em_C
{
    class Program
    {
        static void Main(string[] args)
        {
            // criação dos heróis com suas características (instanciando um objeto)
            Warrior arus = new Warrior("Arus", 23, "Warrior"); 
            Knight ronan = new Knight("Ronan", 26, "Knight");
            Ninja lass = new Ninja("Lass", 24, "Ninja");

            // mostrando uma mensagem no console
            Console.WriteLine(arus.Attack());
            Console.WriteLine(ronan.Attack(2));
            Console.WriteLine(ronan.Attack(7));
            Console.WriteLine(lass.Attack());
        }
    }
}
