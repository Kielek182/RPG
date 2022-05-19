namespace RPG.src.Entities
{
    public class Devil : Personagem
    {
         public Devil(string Name, int Level, string HeroType, int HP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
        }
         public string Defend()
        {
            return this.Name+" "+"Defendeu Tudo!!!"+"\n";
        } 
    }
}