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
    public static int factoryCount = 0;


    void Start()
    {
        factory.SetActive(false);
        buybutton.SetActive(false);
    }
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        costText.GetComponent<Text>().text = "$" + factoryValue;
        if (currentCash >= factoryValue)
        {
            buyImage.SetActive(false);
            buybutton.SetActive(true);
        }
    }
}
