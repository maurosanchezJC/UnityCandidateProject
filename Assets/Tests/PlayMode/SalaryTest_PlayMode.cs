using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class SalaryTest_PlayMode
{
    [UnityTest]
    public IEnumerator CEO()
    {
        var go = new GameObject();
        go.AddComponent<CEO>();
        go.GetComponent<CEO>().IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 20000 + ((20000 * 100) / 100), go.GetComponent<CEO>().GetSalary());
        yield return null;
    }

    [UnityTest]
    public IEnumerator HR_Senior()
    {
        var go = new GameObject();
        go.AddComponent<HR_Senior>();
        go.GetComponent<HR_Senior>().IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 1500 + ((1500 * 5) / 100), go.GetComponent<HR_Senior>().GetSalary());
        yield return null;
    }
    [UnityTest]
    public IEnumerator HR_Ssr()
    {
        var go = new GameObject();
        go.AddComponent<HR_Ssr>();
        go.GetComponent<HR_Ssr>().IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 1000 + ((1000 * 2) / 100), go.GetComponent<HR_Ssr>().GetSalary());
        yield return null;
    }
    [UnityTest]
    public IEnumerator HR_Junior()
    {
        var go = new GameObject();
        go.AddComponent<HR_Junior>();
        go.GetComponent<HR_Junior>().IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 500 + ((500 * 0.5f) / 100), go.GetComponent<HR_Junior>().GetSalary());
        yield return null;
    }

    [UnityTest]
    public IEnumerator Artist_Senior()
    {
        var go = new GameObject();
        go.AddComponent<Artist_Senior>();
        go.GetComponent<Artist_Senior>().IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 2000 + ((2000 * 5) / 100), go.GetComponent<Artist_Senior>().GetSalary());
        yield return null;
    }
    [UnityTest]
    public IEnumerator Artist_Ssr()
    {
        var go = new GameObject();
        go.AddComponent<Artist_Ssr>();
        go.GetComponent<Artist_Ssr>().IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 1200 + ((1200 * 2.5) / 100), go.GetComponent<Artist_Ssr>().GetSalary());
        yield return null;
    }
    [UnityTest]
    public IEnumerator Designer_Junior()
    {
        var go = new GameObject();
        go.AddComponent<Design_Junior>();
        go.GetComponent<Design_Junior>().IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 800 + ((800 * 4) / 100), go.GetComponent<Design_Junior>().GetSalary());
        yield return null;
    }
    [UnityTest]
    public IEnumerator Designer_Senior()
    {
        var go = new GameObject();
        go.AddComponent<Design_Senior>();
        go.GetComponent<Design_Senior>().IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 2000 + ((2000 * 7) / 100), go.GetComponent<Design_Senior>().GetSalary());
        yield return null;
    }
    [UnityTest]
    public IEnumerator Engineer_Junior()
    {
        var go = new GameObject();
        go.AddComponent<Engineer_Junior>();
        go.GetComponent<Engineer_Junior>().IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 1500 + ((1500 * 5) / 100), go.GetComponent<Engineer_Junior>().GetSalary());
        yield return null;
    }
    [UnityTest]
    public IEnumerator Engineer_Senior()
    {
        var go = new GameObject();
        go.AddComponent<Engineer_Senior>();
        go.GetComponent<Engineer_Senior>().IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 5000 + ((5000 * 10) / 100), go.GetComponent<Engineer_Senior>().GetSalary());
        yield return null;
    }
    [UnityTest]
    public IEnumerator Engineer_Ssr()
    {
        var go = new GameObject();
        go.AddComponent<Engineer_Ssr>();
        go.GetComponent<Engineer_Ssr>().IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 3000 + ((3000 * 7) / 100), go.GetComponent<Engineer_Ssr>().GetSalary());
        yield return null;
    }
    [UnityTest]
    public IEnumerator PM_Senior()
    {
        var go = new GameObject();
        go.AddComponent<PM_Senior>();
        go.GetComponent<PM_Senior>().IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 4000 + ((4000 * 10) / 100), go.GetComponent<PM_Senior>().GetSalary());
        yield return null;
    }
    [UnityTest]
    public IEnumerator PM_Ssr()
    {
        var go = new GameObject();
        go.AddComponent<PM_Ssr>();
        go.GetComponent<PM_Ssr>().IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 2400 + ((2400 * 5) / 100), go.GetComponent<PM_Ssr>().GetSalary());
        yield return null;
    }
}
