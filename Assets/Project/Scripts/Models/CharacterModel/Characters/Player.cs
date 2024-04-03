using Project.Scripts.Configs;
using Project.Scripts.Models.CharacterStatistic;

namespace Project.Scripts.Models.CharacterModel
{
    public class Player : CharacterBase
    {
        public Player(PlayerConfig config)
        {
            Stats baseStats = new Stats(config.Physique, config.Strength, config.Dexterity, config.Intelligence);
            SecondStats baseSecondStats = new SecondStats(config.WalkSpeed, config.ShiftSpeed, config.StepSize, config.AttackSpeed, config.RegenerationSpeed);

            SetBaseStats(baseStats);
            SetBaseSecondsStats(baseSecondStats);
        }

        public override void UpdateActualStats()
        {
            ActualStats = BaseStats;
        }

        public override void UpdateSActualecondStats()
        {
            ActualSecondStats = BaseSecondStats;
        }
    }
}