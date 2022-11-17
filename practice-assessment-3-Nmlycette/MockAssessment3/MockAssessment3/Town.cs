using System;
using System.Xml.Linq;

namespace MockAssessment3
{
    public class Town
    {
        public int count;

        // Format: Access Modifier | <CollectionType> | Data/Type (in this case, type is object) | Name of Collection | { get; set; }
        public List<Villager> Villagers { get; set; }

        // Constructor
        public Town()
        {
            Villagers = new List<Villager>();
            Villagers.Add(new Farmer());
            Villagers.Add(new Slacker());
            Villagers.Add(new Slacker());
            Villagers.Add(new Slacker());

            count = Villagers.Count();
        }

        /// OR
        /// public Town()
        /// { 
        ///     Villagers = new List<Villager>() { new Farmer(), new Slacker(), new Slacker(), new Slacker()};
        /// }
   


        public void DisplayVillagers() // practice, not a requirement
        {
            foreach (var villagePerson in Villagers)
            {
                Console.WriteLine(villagePerson.name);
            }
        }

        public int DisplayVillagerCount() // practice, not a requirement
        {
            return count;
        }


        public int CountNumberOfFarmers() // practice, not a requirement
        {
            int farmerCount = 0;
            foreach (var villagePerson in Villagers)
            {
                if (villagePerson.name == "Farmer") // added names to  villager, slacker and farmer classes to run this using friendly names
                {
                    farmerCount++;
                }
            }
            return farmerCount;
        }


        public int CountNumberOfSlackers() // practice, not a requirement
        {
            int slackerCount = 0;
            foreach (var villagePerson in Villagers)
            {
                if (villagePerson.name == "Slacker") // added names to  villager, slacker and farmer classes to run this using friendly names
                {
                    slackerCount++;
                }
            }
            return slackerCount;
        }


        // Method format: access | data return type | method name | pararmeters - what the method takes in to run |

        //public Harvest returns int, finds total of all villager farm methods and returns that total
        //public Harvest() - returns an int
        //Find the total of all the Villagers’ Farm() methods that total
        public int Harvest()
        {
            int totalHarvest = 0;

            foreach (var villagePerson in Villagers)
            {
                totalHarvest += villagePerson.Farm(); //plus equals is incrementally adding the calculation from Farm to the variable, which is currently set at 0
            }
            return totalHarvest;
        }

        //public CalcFoodConsumption() -returns an int
        //Find the total of all the Villagers’ Hunger properties 
        //Return that total
        public int CalcFoodConsumption()
        {
            int totalFoodConsumption = 0;

            foreach (var villagePerson in Villagers)
            {
                totalFoodConsumption += villagePerson.Hunger;
            }
            return totalFoodConsumption;
        }


        //public SurviveTheWinter() -returns a bool
        //Call and store the result of the Harvest() method
        //Call and store the result of the CalcFoodConsumption() method
        //Return true if the value from CalcFoodConsumption is less than or equal to Harvest.
        //Return false if the value from CalcFoodConsumption is greater than Harvest.
        public bool SurviveTheWinter()
        {
            bool foodLessThanHarvest;
            
            int harvestResult = Harvest();
            int foodConsumptionResult = CalcFoodConsumption();

            if (foodConsumptionResult <= harvestResult)
            {
                foodLessThanHarvest = true;
                return foodLessThanHarvest;
            }
            else
            {
                foodLessThanHarvest = false;
                return foodLessThanHarvest; 
            }
        }
    }
}