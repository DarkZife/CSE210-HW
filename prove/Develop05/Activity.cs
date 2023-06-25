using System;

public abstract class Activity
{
    protected string name;
    protected int value;
    public int Value => value;
    public Activity(string name, int value)
    {
        this.name = name;
        this.value = value;
    }

    public string GetName()
    {
        return name;
    }

    public abstract void Complete();
    public abstract string GetStatus();
}