using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCash : MonoBehaviour
{
    public static int CashCount;
    public GameObject CashDisplay;
    public int InternalCash;

    // Update is called once per frame
    void Update()
    {
        InternalCash = CashCount;
        //CashDisplay.GetComponent<Text>().text = "$" + InternalCash;
    }
}
