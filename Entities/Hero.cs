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


        public virtual string Attack(){
                return "basico";
        }
        public abstract string Attack(int bonus);
    }   

        public class Team {
        public string teamName;
        public int noOfPlayers;
        
        public Team(string teamName,int noOfPlayers){
            this.teamName = teamName;
            this.noOfPlayers = noOfPlayers;
        }
        
        public void AddPlayer(int count){
            noOfPlayers += count;
        }
        
        public bool RemovePlayer(int count){
            
            noOfPlayers -= count;
            
            return noOfPlayers > 0 ? true : false;
        }
    }

    public class Subteam: Team {
        
        public Subteam(string teamName,int noOfPlayers) : base (teamName, noOfPlayers){
            
        }
        
            public void ChangeTeamName(string name){
            teamName = name;
        }
        
    }
}