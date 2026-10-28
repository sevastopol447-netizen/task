using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class City
    {
        public int id;
        public int autoInc = 1;
        public string name;
        public string size; // small - 12 слотів під будівництво, medium - 20  слотів під будівництво, large - 36 слотів під будівництво
        public int buildingLimit;
        public List<Building> buildings;
        public int population;
        public int populationGrowth;
        public int happiness;
        public int buildingCount;
        public int moneyIncomePrecentage;
        public City(string name, string size, int population, int happiness)
        {
            this.id = autoInc++;
            this.name = name;
            this.size = size;
            if (size == "small") buildingLimit = 12;
            else if (size == "medium") buildingLimit = 20;
            else buildingLimit = 36;
            this.population = population;
            this.populationGrowth = happiness;
            this.happiness = happiness;
            this.buildingCount = 0;
            buildings = new List<Building>();
        }

        public void UpdateCountryType(string type)
        {
            if (type == "Monarchy") moneyIncomePrecentage += 5;
            else if (type == "Democracy") buildingLimit += 5;
            else happiness += 20;
        }

        public bool AddPopulation(int food)
        {
            if (food >= population / 1000) { population += populationGrowth; return true; }
            else return false;
        }

        public int PayTax()
        {
            if (happiness > 0) return (population / 100) * ((moneyIncomePrecentage / 100) + 1) * (happiness / 10);
            else return 0; // :(
        }

        public void AddBuilding(Building building)
        {
            if (buildingLimit != buildingCount)
            {
                buildings.Add(building);
                buildingCount++;
            }
            else Console.WriteLine("No building space left!!!");
        }

        public void UpdateHapiness()
        {
            happiness = 50;
            foreach (var building in buildings)
            {
                happiness += building.happinessEffect;
            }
            populationGrowth = happiness;
        }

        public void UpdateMoneyIncomePrecentage()
        {
            moneyIncomePrecentage = 0;
            foreach (var building in buildings)
            {
                if (building.resourceType == "moneyIncomePrecentage") moneyIncomePrecentage += building.resourceCount;
            }
        }
    }
}
