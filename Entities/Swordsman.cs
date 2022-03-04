using System.Text;

namespace ExercicioDioAbstracaoRPG.Entities
{
    class Swordsman : Hero
    {
        public string SwordType { get; private set; }

        public Swordsman(string name, int level, int xpInLevel, int attackPower, int defensePower, string swordType)
            : base(name, level, xpInLevel, attackPower, defensePower)
        {
            XP();

            HeroType = "Swordsman";
            SwordType = swordType;
        }

        public override void XP() // If XP in Level is greater than XPmax, go up another level
        {
            int XPmax = 300;
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
            sb.AppendLine($"Sword Type: {SwordType}");

            return sb.ToString();
        }
    }
}

