namespace MockAssessment3
{
    public class Slacker : Villager // Child of Villager
    {
        // Constructor, set hunger property to 3
        public Slacker()
        {
            Hunger = 3;
            name = "Slacker";
        }

        // Methods - Override Farm and return 0
        public override int Farm()
        {
            return 0;
        }
    }
}