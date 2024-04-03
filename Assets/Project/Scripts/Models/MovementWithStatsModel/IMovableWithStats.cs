using Project.Scripts.Core.Interfaces;
using Project.Scripts.Models.CharacterStatistic;

namespace Project.Scripts.Models.MovementWithStatsModel
{
    public interface IMovableWithStats : IMovable
    {
        Stats BaseStats {get;}
        Stats ActualStats {get;}

        SecondStats BaseSecondStats {get;}
        SecondStats ActualSecondStats {get;}
    }
}