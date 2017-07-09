class Item
{
    private double price;
    public virtual double Price
    {
        get { return this.price; }
        set { this.price = value; }
    }
}


class Food : Item
{
    public double Weight;
    public override double Price
    {
        get { return base.Price * this.Weight; }
    }
}

class PickAndMix : Item
{
    public double Count;
    public override double Price
    {
        get { return base.Price * this.Count * 2; }
    }
}


class Program
{

    static double BasketTotal(Item[] basket)
    {
        double total = 0.0;

        foreach (var item in basket)
        {
            total += item.Price;
        }

        return total;
    }


    public static void Main()
    {

        Item[] basket = {
            new Item { Price = 10 },
            new Food { Price = 10, Weight = 2},
            new PickAndMix { Price = 10, Count = 5}
        };


        System.Console.WriteLine(BasketTotal(basket));





        //ASIDE:

        HowMuch(new Item { Price = 10 });
        HowMuch(new Food { Price = 10, Weight = 2 });
        HowMuch(new PickAndMix { Price = 10, Count = 5 });


    }


    //ASIDE: Polymorphic selection of the price
    static void HowMuch(Item p)
    {
        System.Console.WriteLine(p.Price);
    }

}
