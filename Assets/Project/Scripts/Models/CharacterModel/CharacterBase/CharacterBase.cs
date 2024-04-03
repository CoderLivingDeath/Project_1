using Project.Scripts.Models.CharacterStatistic;

namespace Project.Scripts.Models.CharacterModel
{
    public abstract class CharacterBase
    {
        public Stats BaseStats {get; protected set;}
        public Stats ActualStats {get; protected set;}

        public SecondStats BaseSecondStats {get; protected set;}

        public SecondStats ActualSecondStats {get; protected set;}

        public abstract void UpdateActualStats();

        public abstract void UpdateSActualecondStats();

        public void SetBaseStats(Stats stats)
        {
            BaseStats = stats;
            UpdateActualStats();
            UpdateSActualecondStats();
        }

        public void SetBaseSecondsStats(SecondStats stats)
        {
            BaseSecondStats = stats;
            UpdateActualStats();
            UpdateSActualecondStats();
        }
    }
}