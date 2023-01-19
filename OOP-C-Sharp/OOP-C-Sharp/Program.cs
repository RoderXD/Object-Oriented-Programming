
class Car
  {
    public string model;
    public string color;
    public int year;
    
    public Car(string modelName, string modelColor, int modelYear)
    {
      model = modelName;
      color = modelColor;
      year = modelYear;
    }  
  }
class program
{
    static void Main(string[] args)
    {
        Car ford = new Car("Mustang", "Red", 1969);
        Car opel = new Car("Astra", "White", 2005);

        Console.WriteLine(ford.model);
        Console.WriteLine(opel.model);
    }
}
//Program 2

//class Motorcycle
//{
//    public string model;
//    public string color;
//    public int year;

//    public Motorcycle(string modelName, string modelColor, int modelYear)
//    { 
//    model = modelName;
//    color = modelColor; 
//    year = modelYear;
//    }
//}

//class Program2
//{
//    static void Main(string[] args)
//    {
//        Motorcycle Kawasaki = new Motorcycle("Kawasaki", "Green", 2003);
//        Motorcycle Ducati = new Motorcycle("Ducati", "Red", 2018);

//        Console.WriteLine(Kawasaki.model);
//        Console.WriteLine(Ducati.model);
//    }
//}