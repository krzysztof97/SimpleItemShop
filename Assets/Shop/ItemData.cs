using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Shop/Item")]
public class ItemData : ScriptableObject
{
    public int price;
    public new string name;
    public string description;
    public Sprite icon;
}
