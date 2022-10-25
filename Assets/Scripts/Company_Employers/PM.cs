using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PM : WorkPosition
{
    public PM()
    {
        initialSalary = 0;
        incrementPercentage = 0;
    }
    public PM(float aInitialSalary, float aIncrementPercentage) : base(aInitialSalary, aIncrementPercentage)
    {
    }
}
