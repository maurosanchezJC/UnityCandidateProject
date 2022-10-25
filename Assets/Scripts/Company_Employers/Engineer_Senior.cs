using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engineer_Senior : Engineer
{
    public Engineer_Senior()
    {
        initialSalary = 5000;
        incrementPercentage = 10;
    }
    public Engineer_Senior(float aInitialSalary, float aIncrementPercentage) : base(aInitialSalary, aIncrementPercentage)
    {
    }
}
