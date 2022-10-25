using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HR_Senior : HR
{
    public HR_Senior()
    {
        initialSalary = 1500;
        incrementPercentage = 5;
    }
    public HR_Senior(float aInitialSalary, float aIncrementPercentage) : base(aInitialSalary, aIncrementPercentage)
    {
    }

}
