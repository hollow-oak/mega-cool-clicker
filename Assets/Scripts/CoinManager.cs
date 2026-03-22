using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public int TotalCoin;

    [SerializeField] AudioSource CoinSFX;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void OnCoinClicked()
    {
        CoinSFX.Play();
        TotalCoin += 50;
    }
}
