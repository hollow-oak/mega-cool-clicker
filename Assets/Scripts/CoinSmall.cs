using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSmall : MonoBehaviour
{
    CoinManager coinManager;
    [SerializeField] GameObject obj;
    void Start()
    {
        coinManager = obj.GetComponent<CoinManager>();
    }
    public void OnClicked()
    {
        Debug.Log("Bronze Coin Clicked!!!");
        coinManager.AddCoin(10);
        Destroy(gameObject);
    }
}
