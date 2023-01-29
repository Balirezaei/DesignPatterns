namespace StrategyPattern
{
    public class Basket
    {
        public long TotalPrice { get; private set; }

        public void ApplyDiscount(IDiscountStrategy strategy)
        {
            this.TotalPrice = strategy.Calculate(this.TotalPrice);
        }
        public void ApplyDiscountWithContext(IFullContextDiscountStrategy strategy)
        {
            this.TotalPrice = strategy.Calculate(this);
        }
    }
    public class VIPDiscountBasket : Basket
    {
       //Discount ...
    }

    public interface IFullContextDiscountStrategy
    {
        long Calculate(Basket basket);
    }
    public class FullContextVIPCustomerDiscount : IFullContextDiscountStrategy
    {
        public long Calculate(Basket basket)
        {
            return (long)(basket.TotalPrice * (0.33));
        }
    }




    public interface IDiscountStrategy
    {
        long Calculate(long totalPrice);
    }
    public class VIPCustomerDiscount : IDiscountStrategy
    {
        public long Calculate(long totalPrice)
        {
            return (long)(totalPrice *(0.33));
        }
    }

}