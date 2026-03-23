using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGold : MonoBehaviour
{
    CoinManager coinManager;
    [SerializeField] GameObject obj;
    void Start()
    {
        coinManager = obj.GetComponent<CoinManager>();
    }
    public void OnClicked()
    {
        Debug.Log("Gold Coin Clicked!!!");
        coinManager.AddCoin(500);
        Destroy(gameObject);
    }
}
