using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class DestroyTiles : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Priya");
        Invoke("DestroyTile", 3);
    }
    private void DestroyTile()
    {
        Destroy(this.gameObject);
    }
}
