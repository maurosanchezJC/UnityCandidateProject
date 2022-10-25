using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkPosition:MonoBehaviour
{

    [SerializeField]
    protected float initialSalary = 0;

    protected float salary = 0;
    [SerializeField]
    protected float incrementPercentage = 0;

    //constructor
    public WorkPosition()
    {
        salary = 0;
        incrementPercentage = 0;
    }
    //constructor con parametros
    public WorkPosition(float aInitialSalary,float aIncrementPercentage)
    {
        salary = aInitialSalary;
        incrementPercentage = aIncrementPercentage;
    }

    public virtual void IncrementSalaryByPercentage()
    {
        salary = initialSalary + ((initialSalary * incrementPercentage) / 100);
    }

    public float GetSalary()
    {
        return salary;
    }
    public float GetInitialSalary()
    {
        return initialSalary;
    }
    public float GetIncrementPercentage()
    {
        return incrementPercentage;
    }
}
