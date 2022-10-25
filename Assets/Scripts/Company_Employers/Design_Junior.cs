using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Design_Junior : Design
{
    public Design_Junior()
    {
        initialSalary = 800;
        incrementPercentage = 4;
    }
    public Design_Junior(float aInitialSalary, float aIncrementPercentage) : base(aInitialSalary, aIncrementPercentage)
    {
    }
}
