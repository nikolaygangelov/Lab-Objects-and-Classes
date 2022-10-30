

namespace _6._Store_Boxes
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {

            List<Box> boxes = new List<Box>();
            string comman = string.Empty;
            while ((comman = Console.ReadLine()) != "end")
            {
                string[] inputParameters = comman.Split();
                string serialNumber = inputParameters[0];
                string itemName = inputParameters[1];
                int itemQuantity = int.Parse(inputParameters[2]);
                decimal itemPrice = decimal.Parse(inputParameters[3]);

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQuantity);

                boxes.Add(box);
            }

            foreach (Box box in boxes.OrderByDescending(b=>b.BoxPrice))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            } 
        }
    }


    public class Item
    {
        public Item(string itemName, decimal itemPrice)
        {
            Name = itemName;
            Price = itemPrice;
        }
       public string Name { get; set; }
       public decimal Price { get; set; }
    }

    public class Box
    {
        public Box(string serialNumber, Item itemName, int itemQuantity)
        {
            SerialNumber = serialNumber;
            Item = itemName;
            ItemQuantity = itemQuantity;
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }// първото Item e типът на пропъртито т.е. идва от клас Item, а второто Item e просто име на пропъртито
        public int ItemQuantity { get; set; }
        public decimal BoxPrice 
        {
            get
            {
                return ItemQuantity * Item.Price;
            } 
            
            
        }
    }
}
