using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSpawner : MonoBehaviour
{
    public GameObject Ship;
    private float spawnTime;
    public float maxSpawntime;
    public int maxSpawnAmount;


    // Start is called before the first frame update
    void Start()
    {
        spawnTime = maxSpawntime;
    }

    // Update is called once per frame
    void Update()
    {
        if(maxSpawnAmount > 0)
        {
            spawnTime -= Time.deltaTime;
        }
        
        
        if (spawnTime <= 0 && maxSpawnAmount > 0)
        {
            Instantiate(Ship, transform.position, Quaternion.identity);
            maxSpawnAmount -= 1;
            spawnTime = maxSpawntime;
        }


           
    }
}
