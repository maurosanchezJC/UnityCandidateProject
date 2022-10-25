using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engineer : WorkPosition
{
    public Engineer()
    {
        initialSalary = 0;
        incrementPercentage = 0;
    }
    public Engineer(float aInitialSalary, float aIncrementPercentage) : base(aInitialSalary, aIncrementPercentage)
    {
    }
}
