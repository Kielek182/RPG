namespace RPG.src.Entities
{
    public abstract class Personagem
    {
        public Personagem(string Name, int Level, string HeroType,int HP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
        }

        public Personagem(){}

        public string Name;
        public int Level;
        public string HeroType;
        public int HP;

        public override string ToString()
        {
            return "Name: "+this.Name +"\n"+"Lv: "+this.Level+"\n"+"Type: "+this.HeroType+"\n"+"HP: "+this.HP;
        }

        public virtual string Attack()
        {
            return this.Name+" "+"Atacou"+"\n";
        }
        public virtual string Curou()
        {
            return this.Name+" "+"Curou"+"\n";
        }
    }
}