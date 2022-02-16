using GFT_rpg_com_programacao_orientada_a_objetos.src.Base;

namespace GFT_rpg_com_programacao_orientada_a_objetos.src.Entities
{
    public class Wizard : HeroBase
    {
        public Wizard(string name, int level, string HeroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = HeroType;
        }


        public void Attack()
        {
            Console.WriteLine($"{this.Name} lançou uma magia");
        }

        public void Attack(int bonus)
        {
            if (bonus > 6)
            {
                Console.WriteLine($"{this.Name} laçou uma magia forte com o bonus de {bonus}");
            }
            else
            {
                Console.WriteLine($"{this.Name} laçou uma magia fraca com o bonus de {bonus}");
            }
        }
    }
}