namespace Abstracao_Jogo_RPG_em_C.src.Entities
{
    // classe público Warrior que herda a classe Hero
    public class Warrior : Hero
    {
        // construtor com as características
        public Warrior(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            
        }
    }

}