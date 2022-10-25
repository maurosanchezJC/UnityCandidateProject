using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engineer_Junior : Engineer
{
    public Engineer_Junior()
    {
        initialSalary = 1500;
        incrementPercentage = 5;
    }
    public Engineer_Junior(float aInitialSalary, float aIncrementPercentage) : base(aInitialSalary, aIncrementPercentage)
    {
    }
}
