namespace AnimalEmpire
{
    public abstract class Animal
    {
        public double Weight { get; set; }

        public string AnimalName { get; set; }

        public int Age { get; set; }

        public virtual string ShowInfo()
        {
            return $"{GetType().Name} {AnimalName} is {Age} years old, and weighs about {Weight} kilo.";
        }

        public Animal(double Weight, string Name)
        {
            this.Weight = Weight;
            this.AnimalName = Name;
        }
    }
}