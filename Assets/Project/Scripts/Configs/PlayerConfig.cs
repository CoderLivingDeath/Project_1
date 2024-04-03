using Project.Scripts.Models.CharacterStatistic;
using UnityEngine;

namespace Project.Scripts.Configs
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "CharactrsConfigs/PlayerConfig", order = 0)]
    public class PlayerConfig : ScriptableObject
    {
        [field: Header("BaseStats")]
        public int Physique;
        public int Strength;
        public int Dexterity;
        public int Intelligence;

        [Header("BaseSecondStats")]
        public float WalkSpeed;
        public float ShiftSpeed;
        public float StepSize;
        public float AttackSpeed;
        public float RegenerationSpeed;

        public PlayerConfig(int physique, int strength, int dexterity, int intelligence, float walkSpeed, float shiftSpeed, float stepSize, float attackSpeed, float regenerationSpeed)
        {
            Physique = physique;
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
            WalkSpeed = walkSpeed;
            ShiftSpeed = shiftSpeed;
            StepSize = stepSize;
            AttackSpeed = attackSpeed;
            RegenerationSpeed = regenerationSpeed;
        }

        public PlayerConfig(Stats baseStats, SecondStats secondStats)
        {
            Physique = baseStats.Physique;
            Strength = baseStats.Strength;
            Dexterity = baseStats.Dexterity;
            Intelligence = baseStats.Intelligence;
            
            WalkSpeed = secondStats.WalkSpeed;
            ShiftSpeed = secondStats.ShiftSpeed;
            StepSize = secondStats.StepSize;
            AttackSpeed = secondStats.AttackSpeed;
            RegenerationSpeed = secondStats.RegenerationSpeed;
        }
    }
}