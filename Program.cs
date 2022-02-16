// See https://aka.ms/new-console-template for more information
using GFT_rpg_com_programacao_orientada_a_objetos.src.Entities;

namespace GFT_rpg_com_programacao_orientada_a_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 22, "Knight");
            Wizard jennica = new Wizard("Jenica", 30, "Wizard");

            arus.Attack();
            jennica.Attack(1);
        }
    }
}
