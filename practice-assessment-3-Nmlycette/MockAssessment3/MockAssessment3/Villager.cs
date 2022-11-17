namespace MockAssessment3
{
    public abstract class Villager
    {
        public string name; // not required, added for practice

        // public int hunter, do not set value here, determined for the different child types in their respective classes
        public int Hunger { get; set; }

        // Method - Farm returns an int
        public abstract int Farm();
    }
}