
namespace ExercicioDioAbstracaoRPG.Entities
{
    class Apprentice : Hero
    {
        public string ApprenticeType { get; private set; }

        public Apprentice(string name, int level, int xpInLevel, int attackPower, int defensePower)
            : base(name, level, xpInLevel, attackPower, defensePower)
        {
            XP();

            HeroType = "Apprentice";
        }
    }
}
