using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PM_Senior : PM
{
    public PM_Senior()
    {
        initialSalary = 4000;
        incrementPercentage = 10;
    }
    public PM_Senior(float aInitialSalary, float aIncrementPercentage) : base(aInitialSalary, aIncrementPercentage)
    {
    }
}
