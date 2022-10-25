using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Design_Senior : WorkPosition
{
    public Design_Senior()
    {
        initialSalary = 2000;
        incrementPercentage = 7;
    }
    public Design_Senior(float aInitialSalary, float aIncrementPercentage) : base(aInitialSalary, aIncrementPercentage)
    {
    }
}
