using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSilver : MonoBehaviour
{
    public void OnClicked()
    {
        Debug.Log("Silver Coin clicked!!!");
        CoinManager.TotalCoin += 100;
        Destroy(gameObject);
    }
}
