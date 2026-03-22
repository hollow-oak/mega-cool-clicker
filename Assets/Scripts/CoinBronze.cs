using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBronze : MonoBehaviour
{
    CoinManager coinManager;
    public void OnClicked()
    {
        Debug.Log("Bronze Coin Clicked!!!");
        coinManager.OnCoinClicked();
        Destroy(gameObject);
    }
}
