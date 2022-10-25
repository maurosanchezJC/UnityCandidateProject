using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PM_Ssr : PM
{
    public PM_Ssr()
    {
        initialSalary = 2400;
        incrementPercentage = 5;
    }
    public PM_Ssr(float aInitialSalary, float aIncrementPercentage) : base(aInitialSalary, aIncrementPercentage)
    {
    }

}
