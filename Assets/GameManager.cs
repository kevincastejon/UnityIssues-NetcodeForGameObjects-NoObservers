using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void Server()
    {
        NetworkManager.Singleton.StartServer();
    }
    public void Host()
    {
        NetworkManager.Singleton.StartHost();
    }
    public void Join()
    {
        NetworkManager.Singleton.StartClient();
    }
}
