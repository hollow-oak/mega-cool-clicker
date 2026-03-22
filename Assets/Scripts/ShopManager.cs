using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public GameObject shopPanel;
    public bool boughtFactory;
    [SerializeField] AudioSource purchaseSFX;
    CoinManager coinManager;

    [Header("Shop Items")]
    public GameObject FactoryObject;
    public GameObject FactoryButtonText;
    // Start is called before the first frame update
    void Start()
    {
        shopPanel.SetActive(false);
        FactoryObject.SetActive(false);
        boughtFactory = false;
    }
    public void OnShopClicked()
    {
        shopPanel.SetActive(true);
    }
    public void CloseShop()
    {
        shopPanel.SetActive(false);
    }
    public void OnFactoryBuy()
    {
        if (boughtFactory == true)
        {
            
        }
        else
        {
            CoinManager.TotalCoin -= 100;
            FactoryObject.SetActive(true); //passive coin gain starts
            purchaseSFX.Play();
            FactoryButtonText.GetComponent<TextMeshProUGUI>().text = "UPGRADE";
            boughtFactory = true;
            shopPanel.SetActive(false);
        }
    }
}
