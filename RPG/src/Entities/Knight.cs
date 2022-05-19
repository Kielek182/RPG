namespace RPG.src.Entities
{
    public class Knight : Personagem
    {
         public Knight(string Name, int Level, string HeroType, int HP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
        }     
    }
}