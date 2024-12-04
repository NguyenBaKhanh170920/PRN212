internal class Food
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Food() { }
    public Food(int id, string Name)
    {
        Id = id;
        Name = Name;
    }
}