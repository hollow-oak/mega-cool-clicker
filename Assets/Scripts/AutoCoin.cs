using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCoin : MonoBehaviour
{
    public bool CreatingCoin = false;
    public static int coinIncrease = 1;
    public int InternalIncrease;

    void Update()
    {
        coinIncrease = GlobalFactory.factoryPerSec;
        InternalIncrease = coinIncrease;
        if (CreatingCoin == false)
        {
            CreatingCoin = true;
            StartCoroutine(CreateTheCoin());
        }
    }
    IEnumerator CreateTheCoin()
    {
        GlobalCash.CashCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingCoin = false;
    }
}
