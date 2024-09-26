using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float shootTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")&& shootTimer <= 0)
        {
            
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            shootTimer = .5f;
        }
        shootTimer -= Time.deltaTime;

    }
}
