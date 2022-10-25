using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engineer_Ssr : Engineer
{
    public Engineer_Ssr()
    {
        initialSalary = 3000;
        incrementPercentage = 7;
    }
    public Engineer_Ssr(float aInitialSalary, float aIncrementPercentage) : base(aInitialSalary, aIncrementPercentage)
    {
    }
}
