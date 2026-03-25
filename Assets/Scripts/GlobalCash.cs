using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{
    public static int CashCount;
    public GameObject CashDisplay;
    public int InternalCash;

    private void Update()
    {
        InternalCash = CashCount;
        Debug.Log(InternalCash);
        CashDisplay.GetComponent<TextMeshProUGUI>().text = "$" + InternalCash;
    }
}
