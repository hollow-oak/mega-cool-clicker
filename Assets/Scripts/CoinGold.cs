using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGold : MonoBehaviour
{
    public void OnClicked()
    {
        Debug.Log("Gold Coin clicked!!!");
        CoinManager.TotalCoin += 500;
        Destroy(gameObject);
    }
}
