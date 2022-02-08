namespace ProjetoDioOOcomRPG.Entities
{
    public abstract class Hero
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public int HP { get; private set; }
        public int MP { get; private set; }
        public string HeroType { get; private set; }

        public Hero(string name, int level, int hp, int mp, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HP = hp;
            this.MP = mp;
            this.HeroType = heroType;
        }
        
        public abstract string Attack();
        public abstract string Attack(int bonus);

    }
}