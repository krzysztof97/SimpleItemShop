using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsDisplayController : MonoBehaviour
{
    [SerializeField]
    PlayerData playerData;
    TextMeshProUGUI text;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        playerData.OnCoinsChanged += UpdateUI;
        UpdateUI();
    }

    // Update is called once per frame
    void UpdateUI()
    {
        text.SetText(playerData.GetCoins().ToString());
    }
}
