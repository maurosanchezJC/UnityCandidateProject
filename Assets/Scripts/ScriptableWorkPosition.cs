using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WorkPosition", menuName = "Worker", order = 1)]
public class ScriptableWorkPosition : ScriptableObject
{
    public string positionName;
    public int numberOfWorkers;
    public float initialSalary;
    private float salary;
    [Range(0,100)]
    public float annualPercentageIncrease;

    public virtual void IncrementSalaryByPercentage()
    {
        salary = initialSalary + ((initialSalary * annualPercentageIncrease) / 100);
    }

    public float GetSalary()
    {
        return salary;
    }
    public float GetInitialSalary()
    {
        return initialSalary;
    }

    public float GetNumberOfWorkers()
    {
        return numberOfWorkers;
    }
    public float GetAnnualPercentageIncrease()
    {
        return annualPercentageIncrease;
    }
    public string GetName()
    {
        return positionName;
    }

}
