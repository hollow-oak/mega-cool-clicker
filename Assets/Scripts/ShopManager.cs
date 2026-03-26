using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public GameObject shopPanel;
    public GameObject CoinsPerSecond;
    [SerializeField] AudioSource purchaseSFX;
    CoinManager coinManager;
    AudioManager audioManager;

    [Header("Shop Items")]
    public GameObject FactoryObject;
    
    public GameObject AutoCoin;


    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    void Start()
    {
        shopPanel.SetActive(false);
        FactoryObject.SetActive(false);
    }
    public void OnShopClicked()
    {
        shopPanel.SetActive(true);
    }
    public void CloseShop()
    {
        shopPanel.SetActive(false);
    }

    public void StartAutoCoin()
    {
        AutoCoin.SetActive(true);
        FactoryObject.SetActive(true);
        GlobalCash.CashCount -= GlobalFactory.factoryValue;
        GlobalFactory.factoryValue *= 2;
        GlobalFactory.factoryPerSec += 10;
        GlobalFactory.factoryCount += 1;
        audioManager.PlaySFX(audioManager.purchaseSFX);
        CoinsPerSecond.GetComponent<TextMeshProUGUI>().text = "" + GlobalFactory.factoryPerSec;
    }
}
