using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSmall : MonoBehaviour
{
    CoinManager coinManager;
    [SerializeField] GameObject obj;
    GlobalCash globalCash;
    [SerializeField] GameObject objec;
    void Start()
    {
        coinManager = obj.GetComponent<CoinManager>();
        globalCash = objec.GetComponent<GlobalCash>();
    }
    public void OnClicked()
    {
        Debug.Log("Bronze Coin Clicked!!!");
        coinManager.AddCoin(10);
        //globalCash.
        Destroy(gameObject);
    }
}
