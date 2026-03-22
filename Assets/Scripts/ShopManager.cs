using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public GameObject shopPanel;
    // Start is called before the first frame update
    void Start()
    {
        shopPanel.SetActive(false);
    }
    public void OnShopClicked()
    {
        shopPanel.SetActive(true);
    }
}
