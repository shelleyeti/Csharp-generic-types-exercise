namespace the_mall
{
    public interface IStoreable<TItem>
    {
        void AddToInventory(string name, TItem item);

        TItem GetFromInventroy(string name);
    }
}