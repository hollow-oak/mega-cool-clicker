using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalFactory : MonoBehaviour
{
    public GameObject buyImage;
    public GameObject buybutton;
    public GameObject costText;

    public int currentCash;
    public static int factoryValue = 100;
    public GameObject factoryStats;
    public static int factoryCount;
    public static int factoryPerSec;


    void Start()
    {
        buybutton.SetActive(false);
    }
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        factoryStats.GetComponent<TextMeshProUGUI>().text = factoryCount + " factories @" + factoryPerSec + " per min";
        costText.GetComponent<TextMeshProUGUI>().text = "$" + factoryValue;
        if (currentCash >= factoryValue)
        {
            buyImage.SetActive(false);
            buybutton.SetActive(true);
        }
        else
        {
            buyImage.SetActive(true);
            buybutton.SetActive(false);
        }
    }
}
