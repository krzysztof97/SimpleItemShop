using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject coinPrefab;
    float horizontalRange;
    float verticalRange;
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider2D boxCollider = GetComponent<BoxCollider2D>();
        horizontalRange = boxCollider.size.x / 2;
        verticalRange = boxCollider.size.y / 2;
        boxCollider.enabled = false;

        InvokeRepeating(nameof(Spawn), 1f, 1f);
    }

    void Spawn()
    {

        float xPos = Random.Range(-horizontalRange, horizontalRange);
        float yPos = Random.Range(-verticalRange, verticalRange);

        Vector3 position = new Vector3(xPos, yPos);

        Instantiate(coinPrefab, position, Quaternion.identity);
    }
}
