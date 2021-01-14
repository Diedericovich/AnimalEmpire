namespace AnimalEmpire
{
    public enum Hair { Short = 1, Medium = 2, Long = 3, Unknown = 0 }

    public abstract class Mammal : Animal
    {
        public Hair Hair { get; set; }

        public bool IsPregnant { get; set; }

        public void SuckMilk()
        {
        }

        public Mammal(double Weight, string Name, Hair Hair)
            : base(Weight, Name)
        {
            this.Hair = Hair;
        }

        public override string ShowInfo()

        {
            string existingInfo = base.ShowInfo();
            string pregnant = IsPregnant ? "pregnant" : "not pregnant";
            string result = $"{existingInfo}\n  {AnimalName} has {Hair} hair and is {pregnant}";
            return result;
        }
    }
}