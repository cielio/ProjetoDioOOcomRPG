namespace ProjetoDioOOcomRPG.Entities
{
    public class MagicHero : Hero
    {
        public MagicHero(string name, int level, int hp, int mp, string heroType) 
                        : base(name, level, hp, mp, heroType)
        {
        }

        public override string Attack()
        {
           return $"{this.Name} atacou com a Bola de fogo";
        }

        public override string Attack(int bonus)
        {
            return $"{this.Name} atacou com a Bola de fogo, com bonus de {bonus}";
        }
    }
}