namespace RPG.src.Entities
{
    public class Wizard : Personagem
    {
        public Wizard(string Name, int Level, string HeroType, int HP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;               
        }
        public override string Attack()
        {
            return this.Name+" "+"Enfeitiçou"+"\n";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name+" "+"Magicou Demais "+Bonus+"\n";
            }else{
                return this.Name+" "+"Magicou "+Bonus+"\n";
            }
        }
    }
}
