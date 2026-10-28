using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public abstract class Building
    {
        public int id;
        public int autoInc = 1;
        public string name;
        public int price;
        public string resourceType;
        public int resourceCount;
        public int happinessEffect;

        public class Farm : Building
        {
            public Farm(string name, int price)
            {
                this.id = autoInc++;
                this.name = name;
                this.price = price;
                resourceType = "food";  
                resourceCount = 50;
                happinessEffect = 0;
            }
        }
        public class Mine : Building
        {
            public Mine(string name, int price)
            {
                this.id = autoInc++;
                this.name = name;
                this.price = price;
                resourceType = "money";
                resourceCount = 40;
                happinessEffect = -10;
            }
        }
        public class Market : Building
        {
            public Market(string name, int price)
            {
                this.id = autoInc++;
                this.name = name;
                this.price = price;
                resourceType = "money";
                resourceCount = 20;
                happinessEffect = 0;
            }
        }
        public class Bank : Building
        {
            public Bank(string name, int price)
            {
                this.id = autoInc++;
                this.name = name;
                this.price = price;
                resourceType = "moneyIncomePrecentage";
                resourceCount = 5;
                happinessEffect = 0;
            }
        }
        public class Factory : Building
        {
            public Factory(string name, int price)
            {
                this.id = autoInc++;
                this.name = name;
                this.price = price;
                resourceType = "money";
                resourceCount = 50;
                happinessEffect = -10;
            }
        }
        public class Theatre : Building
        {
            public Theatre(string name, int price)
            {
                this.id = autoInc++;
                this.name = name;
                this.price = price;
                resourceType = "-";
                resourceCount = 0;
                happinessEffect = 20;
            }
        }
        public class Museum : Building
        {
            public Museum(string name, int price)
            {
                this.id = autoInc++;
                this.name = name;
                this.price = price;
                resourceType = "-";
                resourceCount = 0;
                happinessEffect = 40;
            }
        }   
    }
}
