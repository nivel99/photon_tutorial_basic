using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class UnirseRoom : MonoBehaviourPunCallbacks
{
    public int numero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UnirseSala()
    {
        PhotonNetwork.JoinRandomRoom();
        Debug.Log("Se unio a una rom aleatoria"+numero);
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("No se pudo unir a inguna, se creara una nueva sala");
        CrearSala();
    }

    public void CrearSala()
    {
        numero = Random.Range(1, 100);
        Debug.Log("Se va a crear una nueva room");
        PhotonNetwork.JoinOrCreateRoom("Sala no" + numero, new RoomOptions() { MaxPlayers = 2 }, TypedLobby.Default);
        Debug.Log("Se creo una nueva room"+numero);
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("No se pudo crear sala");
        CrearSala();
    }


}
