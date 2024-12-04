namespace Q2
{
    internal class Foods
    {
        public string FoodTitle { get; set; }
        public List<Food> ListOfFoods { get; set; }
        public Foods() { }
        public Foods(string foodTitle, List<Food> listOfFoods)
        {
            FoodTitle = foodTitle;
            ListOfFoods = listOfFoods;
        }
        public override string ToString()
        {
            Console.WriteLine("Title: " + FoodTitle);
            foreach (var food in ListOfFoods)
            {
                Console.WriteLine($"Food: {food.Id} - {food.Name}");
            }
            return null;
        }
    }
}
