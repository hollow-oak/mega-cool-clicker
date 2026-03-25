using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoCoinXX;

    public void StartAutoCoinxxxxxx()
    {
        AutoCoinXX.SetActive(true);
        GlobalCash.CashCount -= GlobalFactory.factoryValue;
        GlobalFactory.factoryValue *= 2;
        GlobalFactory.factoryPerSec += 1;
        GlobalFactory.factoryCount += 1;
    }
}
