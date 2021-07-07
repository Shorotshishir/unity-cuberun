using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCalcution
{
    public static int Claculate(int amount, float mitigationPercent)
    {
        var multiplier = 1 - mitigationPercent;
        return Convert.ToInt32(
            amount * (multiplier));
    }
}