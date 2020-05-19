using System;
using System.Collections.Generic;
using System.Linq;

namespace storeBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
                List<Item> items = new List<Item>();
                List<Box> boxes = new List<Box>();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] itemInfo = command.Split().ToArray();

                string serialNum = itemInfo[0];
                string itemName = itemInfo[1];
                int itemQantity = int.Parse(itemInfo[2]);
                decimal itemPrice = decimal.Parse(itemInfo[3]);
                
                Box box = new Box();
                box.Item = new Item();
                
                box.Item.Name = itemName;
                box.SerialNumber = serialNum;
                box.ItemQuantity = itemQantity;
                box.Item.Price = itemPrice;
                
                box.PriceForABox = itemQantity * itemPrice;
                items.Add(box.Item);
                boxes.Add(box);

                command = Console.ReadLine();
            }

            List<Box> sortedList =  boxes.OrderByDescending(box => box.PriceForABox).ToList();
            

            foreach (Box box in sortedList)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
        }
        class Item
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
        class Box
        {
            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemQuantity { get; set; }
            public decimal PriceForABox { get; set; }

            
        }
    }
}
