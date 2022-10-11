using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Player/Data")]
public class PlayerData : ScriptableObject
{
    int coins;

    public int GetCoins() => coins;

    public void IncreaseCoins(int value)
    {
        coins += value;
    }

    public void DecreaseCoins(int value)
    {
        coins -= value;
    }
}
