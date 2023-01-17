//Code without constructors

//The Car is known as a class
class Program
{
  //The Main method is the entry point for all C# programs
  static void Main(string[] args)
  {
    //Create a new object of type Car and assign it to myObj
    Car Ford = new Car();
    //Set the value of the model field of Ford to "Mustang" with the color red and the year 1969
    Ford.model = "Mustang";
    Ford.color = "red";
    Ford.year = 1969;
   
    //Example of creating a new object of type Car using the Car class and setting its values. In this case the model is Astra, the color is white and the year is 2005
    Car Opel = new Car();
    Opel.model = "Astra";
    Opel.color = "white";
    Opel.year = 2005;

    Console.WriteLine(Ford.model);
    Console.WriteLine(Opel.model);
  }
}

//Code with constructors
class Program
{
  static void Main(string[] args)
  {
    //With constructors we can create objects and set their values (fields) all at once
    Car Ford = new Car("Mustang", "Red", 1969);
    Car Opel = new Car("Astra", "White", 2005);

    Console.WriteLine(Ford.model);
    Console.WriteLine(Opel.model);
  }
}