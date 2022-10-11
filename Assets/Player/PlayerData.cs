using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Player/Data")]
public class PlayerData : ScriptableObject
{
    int coins;

    public List<ItemData> items = new List<ItemData>();

    public int GetCoins() => coins;

    public event Action OnCoinsChanged;

    public void IncreaseCoins(int value)
    {
        coins += value;
        OnCoinsChanged.Invoke();
    }

    public void DecreaseCoins(int value)
    {
        coins -= value;
        OnCoinsChanged.Invoke();
    }
}
