using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMaterialsToModel: MonoBehaviour
{
//  public Material Material; 
public Material wall ; 
bool comeHere = true; 
    // Start is called before the first frame update
    void Start()
    {

        GameObject child = GameObject.Find("House_Export1/wall");
          child.GetComponent<MeshRenderer>().material.SetFloat("_Mode", 2);
    }

    // Update is called once per frame
    void Update()
    {

        GameObject child = GameObject.Find("House_Export1/wall");
        child.GetComponent<MeshRenderer>().material = wall;
        // child.GetComponent<MeshRenderer>().material.SetFloat("_Mode", 3);
        
        // color.a = 0.25f; 
       
        // child.GetComponent<MeshRenderer>().material.color = color;

        
        //  child.GetComponent<MeshRenderer>().material.color. = 0.25f;
         GameObject door = GameObject.Find("House_Export1/doorClose");
        door.GetComponent<MeshRenderer>().material.color = Color.blue;
        Transform doorP = door.GetComponent<Transform>();
        if(comeHere == true){
            Vector3 doorPos = new Vector3(doorP.position.x, doorP.position.y, doorP.position.z + 0.13f);
            comeHere = false; 
            door.GetComponent<Transform>().position = doorPos;
        }
        
        Debug.Log("***************************************" + child.name);
        
        
        //child.GetComponent<Renderer>().material = Resourses.Load("green", typeof(Material)) as Material; 
    }
}
