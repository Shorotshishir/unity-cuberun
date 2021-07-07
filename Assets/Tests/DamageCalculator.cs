using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class DamageCalculator
{
    // A Test behaves as an ordinary method
    [Test]
    public void SetDamageToHalfWith50PercentMitigation()
    {
        // ACT
        var finalDamage = DamageCalcution.Claculate(
            10,
            0.5f);

        // ASSERT
        Assert.AreEqual(5, finalDamage);
    }

    [Test]
    public void Calculates2DamageFrom10With80PercentMitigation()
    {
        // ACT
        var finalDamage = DamageCalcution.Claculate(
            10,
            0.8f);

        // ASSERT
        Assert.AreEqual(2, finalDamage);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    /*[UnityTest]
    public IEnumerator DamageCalculatorWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }*/
}