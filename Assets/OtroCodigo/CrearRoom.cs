using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;


public class CrearRoom : MonoBehaviourPunCallbacks
{
    public int numero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void CrearSala()
    {
        numero = Random.Range(1,100);
        Debug.Log("Se va a crear una nueva room");
        PhotonNetwork.JoinOrCreateRoom("Sala no" + numero, new RoomOptions() { MaxPlayers = 2 }, TypedLobby.Default );
        Debug.Log("Se creo una nueva room"+numero);
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("No se pudo crear sala");
        CrearSala();
    }

}
