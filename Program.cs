using System;

namespace Tutoring
{
  public class Naomy
  {
    void BasicVariables()
    {
      /*
       * short,int, long => 0, 1, -12, ..
       * float, double => 0.0, 0.12, -12.12
       * char => 'A', 'a', 'b', ' ', '1'...
       * boolean => true, flase
       */

      char c = '1'; //Excplicit
      var text = "some name"; // Implicit types
      Console.WriteLine(c);
      string name = "A";
    }

    void Interaction()
    {
      // We want to get a persons name, and say hi, name!

      string name = "smith";
      Console.WriteLine("Whats your name? ");
      name = Console.ReadLine();
      Console.WriteLine($"Hi, {name}. How are you?");
      string response = Console.ReadLine();
      if (response.Contains("you"))
      {
        Console.WriteLine("I am fine, thank you.");
      }
      else
      {
        System.Console.WriteLine("Thats goog to hear.");
      }
    }

    void Student_practice()
    {
      // Make a student, with a name, and a grade. print the student name and grade
      Student student = new Student();
      Student student1 = new Student();
      student1.name = "ali";
      student.name = student1.name;

      System.Console.WriteLine(new Student().name);
    }

    static void Main(String[] args)
    {
      new Naomy().Interaction();
    }
  }
}
