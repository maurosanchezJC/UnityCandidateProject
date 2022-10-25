using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HR_Junior : HR
{
    public HR_Junior()
    {
        initialSalary = 500;
        incrementPercentage = 0.5f;
    }
    public HR_Junior(float aInitialSalary, float aIncrementPercentage) : base(aInitialSalary, aIncrementPercentage)
    {
    }

}
