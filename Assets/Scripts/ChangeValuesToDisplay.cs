using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeValuesToDisplay : MonoBehaviour
{
    public Text position;
    public Text totalEmployers;
    public Text initialSalary;
    public Text annualIncrease;
    public Text salaryIncreased;

    public void ChangeTextsWorkerPos(string aPos)
    {
        position.text = aPos;
    }
    public void ChangeTextsTotalEmployers(string atotalEmploy)
    {
        totalEmployers.text = atotalEmploy;
    }
    public void ChangeTextsInitialSalary( string aInitSala)
    {
        initialSalary.text = aInitSala;
    }
    public void ChangeTextsAnnualIncrease(string aAnnualIncre)
    {
        annualIncrease.text = aAnnualIncre;
    }
    public void ChangeTextsSalaryIncreased(string aSalaIncreassed)
    {
        salaryIncreased.text = aSalaIncreassed;
    }





}
