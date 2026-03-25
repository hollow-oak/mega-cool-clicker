using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSilver : MonoBehaviour
{
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    public void OnClicked()
    {
        Debug.Log("Silver Coin Clicked!!!");
        audioManager.PlaySFX(audioManager.coinSFX);
        GlobalCash.CashCount += 100;
        Destroy(gameObject);
    }
}
