using System;

namespace the_mall
{
    class Program
    {
        static void Main(string[] args)
        {
            var Dollarama = new DollarStore();

            var MuiltiColoPen = new DollarItem()
            {
                Name = "Multi Colored Pen with 12 Colors"
            };

            //Add to inventory of Dallarama
            Dollarama.AddToInventory("MCP", MuiltiColoPen);



            var Cinnabon = new FoodStore();
            var CinnamonBun = new FoodItem()
            {
                Name = "Classic Cinnamon Bun",
                Calories = 987,
                Price = 5.00
            };

            Cinnabon.AddToInventory("Pastry", CinnamonBun);



            Console.WriteLine(Dollarama.GetFromInventroy("MCP").Name);
            Console.WriteLine(Cinnabon.GetFromInventroy("Pastry").Name);
        }
    }
}
