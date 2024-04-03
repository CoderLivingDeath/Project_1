namespace Project.Scripts.Models.CharacterStatistic
{
    public readonly struct Stats
    {
        public readonly int Physique;
        public readonly int Strength;
        public readonly int Dexterity;
        public readonly int Intelligence;

        public Stats(int physique, int strength = 0, int dexterity = 0, int intelligence = 0)
        {
            Physique = physique;
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }
    }
}