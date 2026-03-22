using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public GameObject BronzeCoin;
    public GameObject SilverCoin;
    public GameObject GoldCoin;
    public GameObject item;

    void Start()
    {
        item = BronzeCoin;
        StartCoroutine(SpawnCoroutine());
    }
    IEnumerator SpawnCoroutine()
    {
        WaitForSeconds waitTime = new WaitForSeconds(2);
        Instantiate(item);
        yield return waitTime;
    }
}
