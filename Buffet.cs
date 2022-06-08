
  class Buffet
  {
      public List<Food> Menu;
      
      //constructor
      public Buffet()
      {
          Menu = new List<Food>()
          {
              new Food("Burrito", 1000, true, false),
              new Food("Ice Cream", 600, false, true),
              new Food("Spaghetti", 750, false, false),
              new Food("Ramen", 700, false, false),
              new Food("Boba", 300, false, true),
              new Food("Mac n Cheese", 400, false, false),
              new Food("Steak", 550, false, false)
          };
          // Console.WriteLine(Menu[1].Name);
          
      }
      
      public Food Serve()
      {
        Random rand = new Random();
        Food randFood = Menu[rand.Next(Menu.Count)];
        
        return randFood;
      }
  }



