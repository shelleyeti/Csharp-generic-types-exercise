using System.Collections.Generic;

namespace the_mall
{
    public class FoodStore : IStoreable<FoodItem>
    {
        private Dictionary<string, FoodItem> _inventory = new Dictionary<string, FoodItem>();

        public void AddToInventory(string foodName, FoodItem foodItem)
        {
            _inventory.Add(foodName, foodItem);
        }

        public FoodItem GetFromInventroy(string name)
        {
            return _inventory[name];
        }
    }
}