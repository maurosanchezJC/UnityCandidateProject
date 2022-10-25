using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HR_Ssr : HR
{
    public HR_Ssr()
    {
        initialSalary = 1000;
        incrementPercentage = 2;
    }
    public HR_Ssr(float aInitialSalary, float aIncrementPercentage) : base(aInitialSalary, aIncrementPercentage)
    {
    }

}
