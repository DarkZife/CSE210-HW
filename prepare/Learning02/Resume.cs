using System;

public class Resume
{
    public string _name;


    public List<Job> _job = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine("Jobs");

        foreach (Job x in _job)
        {
            x.Display();
        }
    }
}