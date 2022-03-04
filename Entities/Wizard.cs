using System.Text;

namespace ExercicioDioAbstracaoRPG.Entities
{
    class Wizard : Hero
    {
        public string MagicType { get; private set; }

        public Wizard(string name, int level, int xpInLevel, int attackPower, int defensePower, string magicType)
            : base(name, level, xpInLevel, attackPower, defensePower)
        {
            XP();

            HeroType = "Wizard";
            MagicType = magicType;
        }

        public override void XP() // If XP in Level is greater than XPmax, go up another level
        {
            int XPmax = 100;
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
            sb.AppendLine($"Magic Type: {MagicType}");

            return sb.ToString();
        }
    }
}
