public class Student_2
{
  private double gpa;

  public string Name { get; set; }
  public string Pass { get; private set; }
  public double Gpa
  {
    get { return gpa; }
    set
    {
      if (value >= 0)
        gpa = value;
    }
  }

  public Student_2() : this("Ali", 100) { }
  public Student_2(string name, double gpa) => (Name, Gpa) = (name, gpa);

  public override String ToString()
  {
    return $"Student: {Name}, gpa: {Gpa}";
  }

}
