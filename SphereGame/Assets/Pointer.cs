using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public CoinManager CoinManager;

    public Coin ClosestCoin;


    void Update()
    {
        ClosestCoin = CoinManager.GetClosest(transform.position);
        Debug.DrawLine(transform.position, ClosestCoin.transform.position);
    }
}
