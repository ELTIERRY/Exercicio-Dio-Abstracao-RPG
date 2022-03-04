using System.Text;

namespace ExercicioDioAbstracaoRPG.Entities
{
    public abstract class Hero
    {
        public string HeroType { get; private protected set; }

        public string Name { get; private set; }

        public int Level { get; private protected set; }

        public int XpInLevel { get; private protected set; }

        public int AttackPower { get; private set; }

        public int DefensePower { get; private set; }


        public Hero(string name, int level, int xpInLevel, int attackPower, int defensePower)
        {
            //HeroType = "Hero";
            Name = name;
            Level = level;
            XpInLevel = xpInLevel;
            AttackPower = attackPower;
            DefensePower = defensePower;
        }

        public virtual void XP() // If XP in Level is greater than XPmax, go up another level
        {
            int XPmax = 50;
            if (XpInLevel >= XPmax)
            {
                Level += XpInLevel / XPmax; // New Level
                XpInLevel = XpInLevel % XPmax; // New XP in Level

            }
            return;
        }

        public override string ToString() // Joins all hero characteristics in a StringBuilder
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Hero Type: {HeroType}");
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Level: {Level}");
            sb.AppendLine($"XP in Level: {XpInLevel}");
            sb.AppendLine($"Attack Power: {AttackPower}");
            sb.AppendLine($"Defense Power: {DefensePower}");

            return sb.ToString();
        }

    }
}
