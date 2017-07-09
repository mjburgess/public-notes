
class Account
{
    private decimal balance;

    public Account(decimal starting = 100M)
    {
        UpdateBalance(starting);
    }

    public void UpdateBalance(decimal amount)
    {
        balance = amount < 0 ? 0 : amount;
    }

    public decimal GetBalance()
    {
        return balance;
    }
}



class Item
{
    public string Name { get; set; }
    public decimal Price { get; private set; }

    public Item(decimal price)
    {
        Price = price;
    }
}


class Solution6_1
{
    public static void Solution()
    {
        Account defaultA = new Account();
        Account thousandA = new Account(1000M);
        Account negA = new Account(-1000M);

        defaultA.UpdateBalance(defaultA.GetBalance() - 10M);
        thousandA.UpdateBalance(thousandA.GetBalance() - 10M);
        negA.UpdateBalance(negA.GetBalance() - 10M);

        System.Console.WriteLine($"defaultA = {defaultA.GetBalance()}");
        System.Console.WriteLine($"thousandA = {thousandA.GetBalance()}");
        System.Console.WriteLine($"negA = {negA.GetBalance()}");



        var lens = new Item(599.99M)
        {
            Name = "Zeiss 35mm FE"
        };

        System.Console.WriteLine($"{lens.Name} costs {lens.Price}");
    }
}