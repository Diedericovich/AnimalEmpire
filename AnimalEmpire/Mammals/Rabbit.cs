namespace AnimalEmpire
{
    internal sealed class Rabbit : Mammal
    {
        public void BunnyHop()
        {
        }

        public Rabbit(double Weight, string Name, Hair Hair)
            : base(Weight, Name, Hair)
        {
        }

        public bool EatCarrots { get; set; }
    }
}