using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class Player : NetworkBehaviour
{
    NetworkObject _netObject;
    private void Awake()
    {
        _netObject = GetComponent<NetworkObject>();
    }
    public override void OnNetworkSpawn()
    {
        if (NetworkManager.Singleton.IsServer)
        {
            if (NetworkManager.Singleton.LocalClient.PlayerObject == _netObject)
            {
                transform.position = Vector3.left;
            }
            else
            { 
                transform.position = Vector3.right;
            }
        }
    }
}
