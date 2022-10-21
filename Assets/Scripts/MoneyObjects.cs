using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class MoneyObjects : ScriptableObject
{
    public static float money;
    public static float GetMoney()
    {
        return money;
    }
}
