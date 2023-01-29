namespace ObserverPattern.PushModelObserver
{
    public class Item
    {
        public string Name { get; set; }
        public int Size { get; set; }
    }

    public class ItemColection : IMyObserveble<Item>
    {
        public List<IMyObserver<Item>> ItemObservers { get; set; } = new List<IMyObserver<Item>>();

        public List<Item> Items { get; set; } = new List<Item>();
        public void AddItem(Item item)
        {
            Items.Add(item);
            foreach (var ob in ItemObservers)
            {
                //Whole Object pass to Observer that decide to what to do with 
                ob.Notify(item);
            }
        }

        public void Subscribe(IMyObserver<Item> observer)
        {
            ItemObservers.Add(observer);
        }

    }

    public class BoxDisplay : IMyObserver<Item>
    {
        public void Notify(Item value)
        {
            throw new NotImplementedException();
        }
    }

}
