using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GlobalFactory : MonoBehaviour
{
    public GameObject factory;
    public GameObject buyImage;
    public GameObject buybutton;
    public GameObject costText;
    public GameObject buttonText;

    public int currentCash;
    public static int factoryValue = 100;
    public GameObject factoryStats;
    public static int factoryCount;
    public static int factoryPerSec;


    void Start()
    {
        factory.SetActive(false);
        buybutton.SetActive(false);
    }
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        factoryStats.GetComponent<Text>().text = factoryCount + "factories @" + factoryPerSec + " per min";
        costText.GetComponent<Text>().text = "$" + factoryValue;
        if (currentCash >= factoryValue)
        {
            buyImage.SetActive(false);
            buybutton.SetActive(true);
        }
    }
}
