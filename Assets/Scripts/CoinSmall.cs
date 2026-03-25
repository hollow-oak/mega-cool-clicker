using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSmall : MonoBehaviour
{
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    public void OnClicked()
    {
        Debug.Log("Small Coin Clicked!!!");
        audioManager.PlaySFX(audioManager.coinSFX);
        GlobalCash.CashCount += 10;
        Destroy(gameObject);
    }
}
