using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HR : WorkPosition
{
    public HR()
    {
        initialSalary = 0;
        incrementPercentage = 0;
    }
    public HR(float aInitialSalary, float aIncrementPercentage) : base(aInitialSalary, aIncrementPercentage)
    {
    }

}
