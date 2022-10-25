using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artist : WorkPosition
{
    public Artist()
    {
        initialSalary = 0;
        incrementPercentage = 0;
    }
    public Artist(float aInitialSalary, float aIncrementPercentage) : base(aInitialSalary, aIncrementPercentage)
    {
    }
}
