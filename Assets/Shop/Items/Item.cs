using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public ItemData itemData;

    [SerializeField]
    Button buyButton;

    [SerializeField]
    TextMeshProUGUI itemName;

    [SerializeField]
    TextMeshProUGUI itemDescription;

    [SerializeField]
    TextMeshProUGUI itemPrice;

    [SerializeField]
    Image image;

    public event Action<ItemData> ItemBought;

    private void Awake()
    {
        itemName.text = itemData.name;
        itemDescription.text = itemData.description;
        itemPrice.text = itemData.price.ToString();
        image.sprite = itemData.icon;
        image.SetNativeSize();
    }

    public void Buy()
    {
        ItemBought
            .Invoke(itemData);
    }

    public void SetInteractable(bool value)
    {
        buyButton.interactable = value;
    }
}
