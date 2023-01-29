namespace IteratorPattern
{
    public class FruitBasket
    {
        public string[] Fruits = new[] { "apple", "orange", "banana" };
        public Itarator<string> GetItarator()
        {
            return new FruitBasketItarator(Fruits);
        }
    }

    public class FruitBasketItarator : Itarator<string>
    {
        private int index;
        private readonly string[] _fruits;

        public FruitBasketItarator(string[] fruits)
        {
            _fruits = fruits;
        }

        public string CurrentItem()
        {
            return _fruits[index];
        }

        public void IsDone()
        {
            index = _fruits.Length - 1;
        }

        public void Next()
        {
            index++;
        }
    }
    public interface Itarator<T>
    {
        void Next();
        void IsDone();
        T CurrentItem();
    }

}