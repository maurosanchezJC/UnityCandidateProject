using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEO : WorkPosition
{
    public CEO()
    {
        initialSalary = 20000;
        incrementPercentage = 100;
    }
    public CEO(float aInitialSalary, float aIncrementPercentage) : base( aInitialSalary, aIncrementPercentage)
    {
    }

}
