using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode; 
using System;  
// using Globals; 
// using ServerClientButtons;

public class SpawnObject : NetworkBehaviour
{
    // public Transform objects; 
    // public Transform instanceOfRoom; 
    // [SerializeField] public GameObject getServerInfo; 
    // public override void onNetworkSpawn(){
    //     base.onNetworkSpawn();
    // }
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("show me u start here ");
        // Transform instanceOfRoom = Instantiate(objects);
if(Globals.isServer){
            this.GetComponent<NetworkObject>().Spawn(true);
             Debug.Log("this is the instantiation yay2");
            //  this.GetComponent<MeshRenderer>().SetActive(true);
}
if(!Globals.isServer){
    this.GetComponent<MeshRenderer>().enabled = true;
        //    PingClientRpc();
    //    PingServerRpc();
    }
    }

    [ClientRpc]
public void PingClientRpc()
{
        // Debug.Log("this is the instantiation yay1");
        // Transform instanceOfRoom = Instantiate(objects);
        // instanceOfRoom.GetComponent<NetworkObject>().Spawn(true);
       
        
}

        [ServerRpc(RequireOwnership=false)]
public void PingServerRpc()
{
            
        // GameObject instanceOfRoom = Instantiate(objects, objects.transform.position, Quaternion.identity);
        // instanceOfRoom.GetComponent<NetworkObject>().Spawn();
        // Debug.Log("this is the server instanceOfRoom");


}
    // Update is called once per frame
    void Update()
    {
        //  Debug.Log("it comessssss here in the instantiation");
    //    PingClientRpc();
    //    PingServerRpc();
        
    }
}
