using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField]
    PlayerData playerData;

    [SerializeField]
    private List<Item> Items;


    public void Start()
    {
        Items.ForEach(item => { item.ItemBought += OnPurchase; });
        SetInteractables();
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            SetChildrenEnabled(true);
            SetInteractables();
        }
    }

    public void OnPurchase(ItemData itemData)
    {
        playerData.DecreaseCoins(itemData.price);
        playerData.AddItem(itemData);
        SetInteractables();
    }

    private void SetInteractables()
    {
        Items.ForEach(item => {
            item.SetInteractable(playerData.GetCoins() >= item.itemData.price && !playerData.items.Contains(item.itemData));
        });
    }

    public void SetChildrenEnabled(bool value)
    {
        foreach (Transform child in transform.GetComponentInChildren<Transform>())
        {
            child.gameObject.SetActive(value);
        }
    }
}
