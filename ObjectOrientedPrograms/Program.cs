using System;

namespace ObjectOrientedPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to object oriented program");

            Console.WriteLine("==========||==========");

            string path = "C:\\Users\\Dell\\Desktop\\BL_Session\\ObjectOrientedPrograms\\ObjectOrientedPrograms\\Inventory.json";
            string path2 = "C:\\Users\\Dell\\Desktop\\BL_Session\\ObjectOrientedPrograms\\ObjectOrientedPrograms\\Stock.json";

            ReadTheData read = new ReadTheData();

            /*
            InventoryDetails data = read.Read(path);

            Console.WriteLine("==========|Rice|==========");
            for (int i = 0; i < data.typeOfRice.Count; i++)
            {
                Console.WriteLine(data.typeOfRice[i].name);
                Console.WriteLine(data.typeOfRice[i].weight);
                Console.WriteLine(data.typeOfRice[i].price);
                int inventoryprice = data.typeOfRice[i].weight * data.typeOfRice[i].price;
                Console.WriteLine("The Price of {0} Kg of Rice of type {1} is {2} Rs. \n", data.typeOfRice[i].weight, data.typeOfRice[i].name, inventoryprice);
            }
            Console.WriteLine("==========|Pulses|==========");
            for (int j =  0; j < data.typeOfWheats.Count; j++)
            {
                Console.WriteLine(data.typeOfPulses[j].name);
                Console.WriteLine(data.typeOfPulses[j].weight);
                Console.WriteLine(data.typeOfPulses[j].price);
                int inventoryprice = data.typeOfPulses[j].weight * data.typeOfPulses[j].price;
                Console.WriteLine("The Price of {0} Kg of Pulses of type {1} is {2} Rs. \n", data.typeOfPulses[j].weight, data.typeOfPulses[j].name, inventoryprice);
            }
            Console.WriteLine("==========|Wheat|==========");
            for ( int k = 0; k < data.typeOfPulses.Count; k++)
            {
                Console.WriteLine(data.typeOfWheats[k].name);
                Console.WriteLine(data.typeOfWheats[k].weight);
                Console.WriteLine(data.typeOfWheats[k].price);
                int inventoryprice = data.typeOfWheats[k].weight * data.typeOfWheats[k].price;
                Console.WriteLine("The Price of {0} Kg of Wheats of type {1} is {2} Rs. \n", data.typeOfWheats[k].weight, data.typeOfWheats[k].name, inventoryprice);
            }
            */
            StockAccount account = read.Read2(path2);

            Console.WriteLine("==========|Stock Report|==========");
            for (int x = 0 ; x < account.stockReport.Count; x++)
            {
                Console.WriteLine(account.stockReport[x].stockName);
                Console.WriteLine(account.stockReport[x].numberOfShare);
                Console.WriteLine(account.stockReport[x].sharePrice);
                int totalstockprice = account.stockReport[x].numberOfShare * account.stockReport[x].sharePrice;
                double stockprice = account.stockReport[x].sharePrice / account.stockReport[x].numberOfShare;
                Console.WriteLine($"The value of each stock is {stockprice}");
                Console.WriteLine("Total value of stock of {0} is {1}. \n", account.stockReport[x].stockName, totalstockprice);
            }                    
        }
    }
}
