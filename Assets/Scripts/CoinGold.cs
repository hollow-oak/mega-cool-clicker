using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGold : MonoBehaviour
{
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    public void OnClicked()
    {
        Debug.Log("Gold Coin Clicked!!!");
        audioManager.PlaySFX(audioManager.coinSFX);
        GlobalCash.CashCount += 500;
        Destroy(gameObject);
    }
}
