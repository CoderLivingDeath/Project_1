namespace Project.Scripts.Models.CharacterStatistic
{
    public readonly struct SecondStats
    {
        public readonly float WalkSpeed;
        public readonly float ShiftSpeed;

        public readonly float StepSize;

        public readonly float AttackSpeed;

        public readonly float RegenerationSpeed;

        public SecondStats(float walkSpeed, float shiftSpeed, float stepSize, float attackSpeed, float regenerationSpeed)
        {
            WalkSpeed = walkSpeed;
            ShiftSpeed = shiftSpeed;
            StepSize = stepSize;
            AttackSpeed = attackSpeed;
            RegenerationSpeed = regenerationSpeed;
        }

    }
}