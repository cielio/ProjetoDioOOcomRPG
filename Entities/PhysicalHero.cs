namespace ProjetoDioOOcomRPG.Entities
{
    public class PhysicalHero : Hero
    {
        public PhysicalHero(string name, int level, int hp, int mp, string heroType) 
        : base(name, level, hp, mp, heroType)
        {
        }

        public override string Attack()
        {
            return $"{this.Name} Soco basico";
        }

        public override string Attack(int bonus)
        {
            return $"{this.Name} soco basico, com Bonus de {bonus}";
        }
    }
}