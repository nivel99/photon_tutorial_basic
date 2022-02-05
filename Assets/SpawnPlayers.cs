using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    private GameObject playerObj;
    private GameObject cameraObj;
    public Vector3 offset;

    private void FixedUpdate()
    {
        //For camera movement
        if (playerObj != null && cameraObj != null )
        {
            cameraObj.transform.position = playerObj.transform.position - offset;
        }
    }

    private void Start()
    {
        Vector2 randomPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY,maxY));
        //PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
        playerObj = PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
        cameraObj = Camera.main.gameObject;
        cameraObj.transform.position = playerObj.transform.position;
    }

}
