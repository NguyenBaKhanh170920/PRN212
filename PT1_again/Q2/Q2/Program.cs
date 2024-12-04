using Q2;
class Program
{
    static void Main(string[] args)
    {
        List<Food> fl = new List<Food>();
        int numberFoods;
        Console.Write("Enter the number of foods:");
        numberFoods = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberFoods; i++)
        {
            Food food = new Food();
            Console.Write("Enter ID:");
            food.Id = int.Parse(Console.ReadLine());
            Console.Write("Enter name:");
            food.Name = Console.ReadLine();
            fl.Add(food);
        }
        Foods foods = new Foods("Fruit", fl);

        Console.WriteLine("OUTPUT:");
        Console.Write(foods);

        Console.ReadLine();
    }
}
