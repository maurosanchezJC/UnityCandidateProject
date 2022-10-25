using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artist_Ssr : Artist
{
    public Artist_Ssr()
    {
        initialSalary = 1200;
        incrementPercentage = 2.5f;
    }
    public Artist_Ssr(float aInitialSalary, float aIncrementPercentage) : base(aInitialSalary, aIncrementPercentage)
    {
    }
}
