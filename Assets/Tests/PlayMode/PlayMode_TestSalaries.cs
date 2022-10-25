using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayMode_TestSalaries
{
    // A Test behaves as an ordinary method
    [Test]
    public void CEO()
    {
        var ceoTest = ScriptableObject.CreateInstance<ScriptableWorkPosition>();
        ceoTest.annualPercentageIncrease = 100;
        ceoTest.initialSalary = 20000;

        ceoTest.IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 20000 + ((20000 * 100) / 100), ceoTest.GetSalary());
    }
    [Test]
    public void HR_Senior()
    {
        var ceoTest = ScriptableObject.CreateInstance<ScriptableWorkPosition>();
        ceoTest.annualPercentageIncrease = 5;
        ceoTest.initialSalary = 1500;

        ceoTest.IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 1500 + ((1500 * 5) / 100), ceoTest.GetSalary());
    }
    [Test]
    public void HR_Ssr()
    {
        var ceoTest = ScriptableObject.CreateInstance<ScriptableWorkPosition>();
        ceoTest.annualPercentageIncrease = 2;
        ceoTest.initialSalary = 1000;

        ceoTest.IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 1000 + ((1000 * 2) / 100), ceoTest.GetSalary());
    }
    [Test]
    public void HR_Junior()
    {
        var ceoTest = ScriptableObject.CreateInstance<ScriptableWorkPosition>();
        ceoTest.annualPercentageIncrease = 0.5f;
        ceoTest.initialSalary = 500;

        ceoTest.IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 500 + ((500 * 0.5f) / 100), ceoTest.GetSalary());
    }
    [Test]
    public void Artist_Senior()
    {
        var ceoTest = ScriptableObject.CreateInstance<ScriptableWorkPosition>();
        ceoTest.annualPercentageIncrease = 5;
        ceoTest.initialSalary = 2000;

        ceoTest.IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 2000 + ((2000 * 5) / 100), ceoTest.GetSalary());
    }
    [Test]
    public void Artist_Ssr()
    {
        var ceoTest = ScriptableObject.CreateInstance<ScriptableWorkPosition>();
        ceoTest.annualPercentageIncrease = 2.5f;
        ceoTest.initialSalary = 1200;

        ceoTest.IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 1200 + ((1200 * 2.5) / 100), ceoTest.GetSalary());
    }
    [Test]
    public void Designer_Junior()
    {
        var ceoTest = ScriptableObject.CreateInstance<ScriptableWorkPosition>();
        ceoTest.annualPercentageIncrease = 4f;
        ceoTest.initialSalary = 800;

        ceoTest.IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 800 + ((800 * 4) / 100), ceoTest.GetSalary());
    }
    [Test]
    public void Designer_Senior()
    {
        var ceoTest = ScriptableObject.CreateInstance<ScriptableWorkPosition>();
        ceoTest.annualPercentageIncrease = 7f;
        ceoTest.initialSalary = 2000;

        ceoTest.IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 2000 + ((2000 * 7) / 100), ceoTest.GetSalary());
    }
    [Test]
    public void Engineer_Junior()
    {
        var ceoTest = ScriptableObject.CreateInstance<ScriptableWorkPosition>();
        ceoTest.annualPercentageIncrease = 5f;
        ceoTest.initialSalary = 1500;

        ceoTest.IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 1500 + ((1500 * 5) / 100), ceoTest.GetSalary());
    }
    [Test]
    public void Engineer_Senior()
    {
        var ceoTest = ScriptableObject.CreateInstance<ScriptableWorkPosition>();
        ceoTest.annualPercentageIncrease = 10f;
        ceoTest.initialSalary = 5000;

        ceoTest.IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 5000 + ((5000 * 10) / 100), ceoTest.GetSalary());
    }
    [Test]
    public void Engineer_Ssr()
    {
        var ceoTest = ScriptableObject.CreateInstance<ScriptableWorkPosition>();
        ceoTest.annualPercentageIncrease = 7;
        ceoTest.initialSalary = 3000;

        ceoTest.IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 3000 + ((3000 * 7) / 100), ceoTest.GetSalary());
    }
    [Test]
    public void PM_Senior()
    {
        var ceoTest = ScriptableObject.CreateInstance<ScriptableWorkPosition>();
        ceoTest.annualPercentageIncrease = 10;
        ceoTest.initialSalary = 4000;

        ceoTest.IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 4000 + ((4000 * 10) / 100), ceoTest.GetSalary());
    }
    [Test]
    public void PM_Ssr()
    {
        var ceoTest = ScriptableObject.CreateInstance<ScriptableWorkPosition>();
        ceoTest.annualPercentageIncrease = 5;
        ceoTest.initialSalary = 2400;

        ceoTest.IncrementSalaryByPercentage();
        Assert.AreEqual(expected: 2400 + ((2400 * 5) / 100), ceoTest.GetSalary());
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
   /* [UnityTest]
    public IEnumerator PlayMode_TestSalariesWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }*/
}
