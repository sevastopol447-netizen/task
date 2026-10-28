using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static task.Building;

namespace task
{
    public class BuildingCreator
    {
        public Farm CreateFarm(string name, int price = 1500)
        {
            Farm building = new Farm(name, price);
            return building;
        }
        public Mine CreateMine(string name, int price = 1500)
        {
            Mine building = new Mine(name, price);
            return building;
        }
        public Market CreateMarket(string name, int price = 1500)
        {
            Market building = new Market(name, price);
            return building;
        }
        public Bank CreateBank(string name, int price = 1500)
        {
            Bank building = new Bank(name, price);
            return building;
        }
        public Factory CreateFactory(string name, int price = 1500)
        {
            Factory building = new Factory(name, price);
            return building;
        }
        public Theatre CreateTheatre(string name, int price = 1500)
        {
            Theatre building = new Theatre(name, price);
            return building;
        }

        public Museum CreateMuseum(string name, int price = 1500)
        {
            Museum building = new Museum(name, price);
            return building;
        }
    }
}
