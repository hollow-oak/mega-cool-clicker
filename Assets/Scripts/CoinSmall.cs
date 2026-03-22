using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSmall : MonoBehaviour
{
    public void OnClicked()
    {
        Debug.Log("SmallCoin clicked!!!");
        CoinManager.TotalCoin += 10;
        Destroy(gameObject);
    }
}
