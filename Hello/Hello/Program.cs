using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace Hello
{
     // Interface
     interface IAnimal 
  {
    void animalSound(); // interface method (does not have a body)
  }

  // Pig "implements" the IAnimal interface
  class Pig : IAnimal 
  {
    public void animalSound() 
    {
      // The body of animalSound() is provided here
      Console.WriteLine("The pig says: wee wee");
    }
  }

    //Multiple Interfaces || Multiple inheritance A,B=>C
    interface IFirstInterface 
{
  void myMethod(); // interface method
}

interface ISecondInterface 
{
  void myOtherMethod(); // interface method
}

// Implement multiple interfaces
class DemoClass : IFirstInterface, ISecondInterface 
{
  public void myMethod() 
  {
    Console.WriteLine("Some text..");
  }
  public void myOtherMethod() 
  {
    Console.WriteLine("Some other text...");
  }
}

    internal class Program
    {
        //Method Overloading
         static float Average(int a, int b, int c)
        {
            float sum = a + b + c;
            return sum / 3;
        }
        static float Average(int a, int b)
        {
            return (a + b) / 2;

        }       
 
        //Polymorphisum
      //  class Animal  // Base class (parent) 
//{
  //public virtual void animalSound()     
  //{
    //Console.WriteLine("The animal makes a sound");
  //} 
//}

//class Pig : Animal  // Derived class (child) 
//{
  //public override void animalSound() 
  //{
    //Console.WriteLine("The pig says: wee wee");
  //}
//}

//class Dog : Animal  // Derived class (child) 
//{
  //public override void animalSound() 
  //{
    //Console.WriteLine("The dog says: bow wow");
//  }
//}


        //Constructor
        public string model;  // Create a field

        // Create a class constructor with a parameter
        public string colour;

        // Create a class constructor for the Car class
        public Program(string colourName)
        {
            model = "Mustang"; // Set the initial value for model
            colour = colourName;
        }

        //Exception Handling
        //throw keyword
      //      static void checkAge(int age)
  //      {
    //    if (age < 18)
     //  {
    //      throw new ArithmeticException("Access denied - You must be at least 18 years old.");
    //    }
    //    else
   //      {
    //      Console.WriteLine("Access granted - You are old enough!");
    //    }
   //      
   //    }

       
       
        //static async void Main(string[] args)
        
        // Using Threads Async Await
        static async Task Main(string[] args)

            {
            //String
            //string firstName = "John";
            //string lastName = "Doe";
            //string name = $"My full name is: {firstName} {lastName}";
            //Console.WriteLine(name);


            //Method Overloading
            //Console.WriteLine(Average(9, 3, 0));
            //Console.WriteLine(Average(3, 3));

            // OOPs - Classes & objects
            //Player tom = new Player();
            //Console.WriteLine(tom.gethealth());
            //tom.sethealth(40);

            //Member function
            //Console.WriteLine(tom.gethealth());

            //Car Ford = new Car();
            //Ford.model = "Mustang";
            //Ford.color = "red";
            //Ford.year = 1969;

            //Car Opel = new Car();
            //Opel.model = "Aston Martin";
            //Opel.color = "Grey";
            //Opel.year = 2005;

            //Console.WriteLine(Ford.model);
            //Console.WriteLine(Opel.color);

            // Ford.fullThrottle();  // Call the method

            //Constructor   //Can be use to replace Member Function
            //Program ford = new Program("red");// Create an object of the Car Class (this will call the constructor)

            //Console.WriteLine(ford.model);  // Print the value of model
            //Console.WriteLine(ford.colour);  // Print the value of model

            //Properties
            //Player myObj = new Player();
           // myObj.Name = "Liam";
            //Console.WriteLine(myObj.Name);

            //Inheritance
            // Create a myCar object
   // Car myCar = new Veh();

    // Call the honk() method (From the Vehicle class) on the myCar object
   // myCar.honk();

    // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
    //Console.WriteLine(myCar.brand + " " + myCar.modelName);


         //   Animal myAnimal = new Animal();  // Create a Animal object
    //Animal myPig = new Pig();  // Create a Pig object
    //Animal myDog = new Dog();  // Create a Dog object

    //myAnimal.animalSound();
    //myPig.animalSound();
    //myDog.animalSound();

            //Interface
      //       Pig myPig = new Pig();  // Create a Pig object
     // myPig.animalSound();
//
            //Multiple Interface
    //        DemoClass myObj = new DemoClass();
    //myObj.myMethod();
   // myObj.myOtherMethod();

            //Exception handling
            //checkAge(10);

             //try
           //{
            //int[] myNumbers = {1, 2, 3};
           // Console.WriteLine(myNumbers[10]);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Something went wrong.");
           // }
            //finally
            //{
             //   Console.WriteLine("The 'try catch' is finished.");
            //}

            //Async Await & Thread
            //var client = new HttpClient();
            
           // var task = await client.GetStringAsync("https://google.com");
           // int a = 0;
           // Console.WriteLine("Doing something else");
           // for(int i = 0; i < 1_000_000; i++)
           // {
           //     a = i+1;
           // }

            //Console.WriteLine("Returning to previous task")
            //var task2 = await client.GetStringAsync("https://google.com");
           // Console.WriteLine("Hello World!");

            //Events & Delegates
            var video = new Video() { Title = "Video 1"};
            var videoEncoder = new VideoEncoder();

            videoEncoder.Encode(video);


            Console.ReadLine();
            }
        }
    }
