using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Design : WorkPosition
{
    public Design()
    {
        initialSalary = 0;
        incrementPercentage = 0;
    }
    public Design(float aInitialSalary, float aIncrementPercentage) : base(aInitialSalary, aIncrementPercentage)
    {
    }
}
