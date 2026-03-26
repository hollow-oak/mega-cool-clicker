using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject SmallCoin;
    public GameObject BronzeCoin;
    public GameObject SilverCoin;
    public GameObject GoldCoin;

    public RectTransform spawnArea;

    void Start()
    {
        StartCoroutine(SpawnCoin(SmallCoin, 1));
        StartCoroutine(SpawnCoin(BronzeCoin, 2));
        StartCoroutine(SpawnCoin(SilverCoin, 3));
        StartCoroutine(SpawnCoin(GoldCoin, 4));
    }
    public Vector3 GenerateRandomPoint(Transform area)
    {
        int spawnPointX = Random.Range(-218, 218);
        int spawnPointY = Random.Range(-235, 235); //there has to be a better way of doing this..
        Vector3 randomVector = new Vector3(spawnPointX, spawnPointY);
        randomVector = area.TransformPoint(randomVector);
        return randomVector;
    }
    IEnumerator SpawnCoin(GameObject coinType, int spawnTime)
    {
        while (true)
        {
            Vector3 randomPos = GenerateRandomPoint(spawnArea);
            yield return new WaitForSeconds(spawnTime);
            GameObject coin = Instantiate(coinType, randomPos, Quaternion.identity);
            coin.transform.SetParent(spawnArea);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, 25);
    }
}