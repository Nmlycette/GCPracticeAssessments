namespace MockAssessment3
{
    public class Farmer : Villager // Child of Villager
    {
        // Constuctor - set Hunger to 1
        public Farmer()
        {
            Hunger = 1;
            name = "Farmer";
        }


        // Methods - Override Farm and return 2
        public override int Farm()
        {
            return 2;
        }
    }
}