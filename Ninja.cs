class Ninja
{
    private int CalorieIntake;
    public List<Food> FoodHistory;
    // add a constructor
    public Ninja()
    {
      CalorieIntake = 0;
      FoodHistory = new List<Food>();
    }
    // add a public "getter" property called "IsFull"
    public bool IsFull
    {
      get
      {
        return CalorieIntake >= 1200;
      }
    }
    // build out the Eat method
    public void Eat(Food item)
    {
      if (!IsFull) 
      {
        CalorieIntake += item.Calories;
        FoodHistory.Add(item);
        Console.WriteLine($"Ninja just ate {item.Name}");
        if (item.IsSpicy == true)
        {
          Console.WriteLine("This is spicy!");
        }
        else if (item.IsSweet == true)
        {
          Console.WriteLine("This is Sweet!");
        }
      }
      else
      {
        Console.WriteLine("Ninja is full!");
      }
    }
}

