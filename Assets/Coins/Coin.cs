using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    [SerializeField]
    PlayerData playerData;
    [SerializeField] int coinsToIncrease = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerData.IncreaseCoins(coinsToIncrease);
            Destroy(gameObject);
        }
    }
}
