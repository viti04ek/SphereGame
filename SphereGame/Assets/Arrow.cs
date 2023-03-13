using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Transform PlayerTransform;

    public CoinManager CoinManager;

    private Transform _targetCoin;

    
    void Update()
    {
        transform.position = new Vector3(PlayerTransform.position.x, PlayerTransform.position.y + 0.7f, PlayerTransform.position.z);


        _targetCoin = CoinManager.GetClosest(PlayerTransform.position).transform;

        Vector3 toTarget = _targetCoin.position - PlayerTransform.position;
        transform.rotation = Quaternion.LookRotation(toTarget);
    }
}
