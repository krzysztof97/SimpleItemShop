using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserItems : MonoBehaviour
{
    // Start is called before the first frame update

    public PlayerData playerData;
    Image[] itemsImages;

    private void Start()
    {
        itemsImages = GetComponentsInChildren<Image>();
        playerData.OnItemsChanged += UpdateUserItems;
        UpdateUserItems();
    }

    void UpdateUserItems()
    {
        int i = 0;
        foreach(ItemData item in playerData.items)
        {
            itemsImages[i].sprite = item.icon;
            i++;
        }
    }

}
