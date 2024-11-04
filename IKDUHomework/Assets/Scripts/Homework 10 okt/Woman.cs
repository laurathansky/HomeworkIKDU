using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Woman
{
    public string Name { get; private set; }

    public Woman(string name)
    {
        this.Name = name;
    }

    //allows to overide from mom child class
    public virtual string GetCycleInfo(int dayOfCycle)
    {
        return $"{Name}'s cycle is {dayOfCycle} days.";
    }
}


public class Mom : Woman
{
    public Mom(string name) : base(name) { }

    public override string GetCycleInfo(int dayOfCycle)
    {
        return $"{Name} is in menopause.";
    }
}

