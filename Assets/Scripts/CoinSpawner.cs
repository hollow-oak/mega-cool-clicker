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
    public float Radius;
    void Start()
    {
        StartCoroutine(SpawnCoin(SmallCoin, 1));
        StartCoroutine(SpawnCoin(BronzeCoin, 2));
        StartCoroutine(SpawnCoin(SilverCoin, 3));
        StartCoroutine(SpawnCoin(GoldCoin, 4));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
    IEnumerator SpawnCoin(GameObject coinType, int spawnTime)
    {
        while (true)
        {
            //Vector3 randomPos = GenerateRandomPoint();
            Vector3 randomPos = Random.insideUnitCircle * Radius;
            yield return new WaitForSeconds(spawnTime);
            GameObject coin = Instantiate(coinType, randomPos, Quaternion.identity);
            coin.transform.SetParent(spawnArea);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, Radius);
    }
}