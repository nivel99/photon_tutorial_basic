using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class ConnectToMaster : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.GameVersion = "0.1";
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("Se ha conectado al servidor Master");
    }


    public override void OnConnectedToMaster()
    {
        Debug.Log("Se ha conectado al servidor maestro");
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("Problema al conectar con el servidor");
    }

}
