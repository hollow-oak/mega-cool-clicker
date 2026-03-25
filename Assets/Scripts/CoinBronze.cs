using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBronze : MonoBehaviour
{
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    public void OnClicked()
    {
        Debug.Log("Bronze Coin Clicked!!!");
        audioManager.PlaySFX(audioManager.coinSFX);
        GlobalCash.CashCount += 50;
        Destroy(gameObject);
    }
}
