using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class tilescript : MonoBehaviour
{
   /* public GameObject prefabs;*/
    public List<GameObject> tiles;
    public int tileindex = 4;
    
    public int spawnz = 0;
    public int tilelength = 10                                                                                                                                                              ;
    public int tileamount = 4;
    public Transform playertransform;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < tileamount; i++)
        {
            spawner();
        }

    }

    // Update is called once per frame
    void Update()
    {   
        if (playertransform.position.z> spawnz - (tileamount * tilelength)) 
            {

            spawner();

        }
        
    }

    public void spawner()
    {
        GameObject newtile = Instantiate(tiles[tileindex], transform.forward * spawnz, transform.rotation);
        spawnz += tilelength;
    }
}
