using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Country
    {
        public int id;
        public int autoInc = 1;
        public string name;
        public string govermentType;   //Monarchy, Democracy, Dictatorship Monarchy - більший відсоток податку з міст. Democracy - більше місць для будівництва в містах. Dictatorship - базовий параметр щастя в містах завжди +20.
        public Dictionary<string, int> resources;
        public List<City> cities;
        public int happiness;
        public int money;

        public Country(string name, string govermentType, int money)
        {
            id = autoInc++;
            this.govermentType = govermentType;
            this.money = money;
            cities = new List<City>();
            resources = new Dictionary<string, int>();
        }

        public string GetGovermentType() {return govermentType;}

        public void AddCity(City city) { cities.Add(city); }

        public Dictionary<string, int> GetResources() { return resources; }

        public void SimulateMonth()
        {
            List<int> cityHappiness = new List<int>();
            foreach (City city in cities)
            {
                city.UpdateHapiness();
                city.UpdateMoneyIncomePrecentage();

                Console.WriteLine("List of buildings in city: ");
                foreach (Building building in city.buildings) 
                {
                    Console.WriteLine(building.name);
                    if (city.happiness > 0) 
                    {
                        if (!resources.ContainsKey(building.resourceType)) resources.Add(building.resourceType, building.resourceCount);
                        else resources[building.resourceType] += building.resourceCount;
                    }
                }

                if (resources.ContainsKey("food"))
                {
                    if (city.AddPopulation(resources["food"])) resources["food"] -= 1;
                    else city.happiness -= 10;
                }
                
                Console.WriteLine("/--------------------------------------------------");
                Console.WriteLine(city.name);

                Console.WriteLine("");
                Console.WriteLine("Population: " + city.population + " people");
                Console.WriteLine("Happiness: " + city.happiness + "%");
                cityHappiness.Add(city.happiness);
                Console.WriteLine("Tax city priduced: " + city.PayTax() + " money");
                Console.WriteLine("");

                money += city.PayTax();
            }

            Console.WriteLine("Country stats:");
            Console.WriteLine("Average happiness: " + cityHappiness.Average());
            Console.WriteLine("");
            Console.WriteLine("Money: " + money);
            Console.WriteLine("Food: " + resources["food"]);
        }
    }
}
