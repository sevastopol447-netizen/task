using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BuildingCreator BuildingCreator = new BuildingCreator();

            Country country = new Country("Newwille", "Democracy", 100000);

            City city1 = new City("Ligerburg", "small", 1000, 50);
            City city2 = new City("Westernwille", "medium", 1000, 50);
            City city3 = new City("Chrinvelston", "large", 1000, 50);

            Building.Farm farm1 = BuildingCreator.CreateFarm("Chicken farm", 1500);
            Building.Mine mine1 = BuildingCreator.CreateMine("Friedricks mine", 3500);
            Building.Market market1 = BuildingCreator.CreateMarket("Supermarket", 2000);
            Building.Factory factory1 = BuildingCreator.CreateFactory("Happy factory", 5000);
            Building.Factory factory2 = BuildingCreator.CreateFactory("Brick factory", 5000);
            Building.Bank bank1 = BuildingCreator.CreateBank("Greedy bank", 6000);
            Building.Bank bank2 = BuildingCreator.CreateBank("Welcome bank", 6000);
            Building.Museum museum1 = BuildingCreator.CreateMuseum("History museum about prehistorical ages", 2500);
            Building.Theatre theatre1 = BuildingCreator.CreateTheatre("National theatre of peace", 3000);

            city1.AddBuilding(farm1);
            city1.AddBuilding(factory1);
            city1.AddBuilding(bank1);

            city2.AddBuilding(market1);
            city2.AddBuilding(mine1);
            city2.AddBuilding(museum1);

            city3.AddBuilding(factory2);
            city3.AddBuilding(theatre1);
            city3.AddBuilding(bank2);

            country.AddCity(city1);
            country.AddCity(city2);
            country.AddCity(city3);


            while (true)
            {
                country.SimulateMonth();
                if (Console.ReadLine() == "0010")
                {
                    for (int i = 0; i < 12; i++)
                    {
                        country.SimulateMonth();
                    }
                }
            }
        }
    }
}
