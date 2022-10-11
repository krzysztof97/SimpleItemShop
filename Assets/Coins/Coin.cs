using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    [SerializeField]
    PlayerData playerData;
    
    [SerializeField] 
    int coinsToIncrease = 1;

    [SerializeField]
    private float timeToDestroy = 5f;

    void Start()
    {
        Invoke(nameof(DestroyMe), timeToDestroy);    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerData.IncreaseCoins(coinsToIncrease);
            CancelInvoke(nameof(DestroyMe));
            DestroyMe();
        }
    }

    private void DestroyMe()
    {
        Destroy(gameObject);
    }
}
