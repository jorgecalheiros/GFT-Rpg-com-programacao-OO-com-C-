using GFT_rpg_com_programacao_orientada_a_objetos.src.Base;

namespace GFT_rpg_com_programacao_orientada_a_objetos.src.Entities
{
    public class Knight : HeroBase
    {
        public Knight(string name, int level, string HeroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = HeroType;
        }

        public void Attack()
        {
            Console.WriteLine($"{this.Name} atacou com a espada");
        }
    }
}