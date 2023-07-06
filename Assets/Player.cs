using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class Player : NetworkBehaviour
{
    public static int _playersCount;

    NetworkObject _netObject;
    private void Awake()
    {
        _netObject = GetComponent<NetworkObject>();
    }
    public override void OnNetworkSpawn()
    {
        if (NetworkManager.Singleton.IsServer)
        {
            transform.position = Vector3.right * _playersCount;
            _playersCount++;
        }
    }
}
