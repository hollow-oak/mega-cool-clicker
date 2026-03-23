using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public static int TotalCoin;
    public int CoinPerMinute;
    public GameObject TotalMoneyText;
    public GameObject CoinPerMinuteText;

    [SerializeField] AudioSource CoinSFX;
    void Start()
    {
        TotalCoin = 0;
    }
    private void Update()
    {
        TotalMoneyText.GetComponent<TextMeshProUGUI>().text = "$" + TotalCoin;
    }
    public void OnCoinClicked()
    {
        AddCoin(10);
    }
    public void AddCoin(int amt)
    {
        TotalCoin += amt;
        CoinSFX.Play();
    }
}
