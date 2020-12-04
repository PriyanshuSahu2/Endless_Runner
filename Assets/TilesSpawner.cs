using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesSpawner : MonoBehaviour
{
    public GameObject tiles;
    float tilesNect;
    public GameObject[] totalTiles;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalTiles = GameObject.FindGameObjectsWithTag("Tiles");
        if(totalTiles.Length <10)
        {
            GameObject tilsnext = Instantiate(tiles, new Vector3(0, 0, tilesNect), Quaternion.identity);
            tilesNect = tilsnext.transform.position.z + 10;
        }

        
    }
}
