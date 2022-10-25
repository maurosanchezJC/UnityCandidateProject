using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artist_Senior : Artist
{
    public Artist_Senior()
    {
        initialSalary = 2000;
        incrementPercentage = 5;
    }
    public Artist_Senior(float aInitialSalary, float aIncrementPercentage) : base(aInitialSalary, aIncrementPercentage)
    {
    }
}
