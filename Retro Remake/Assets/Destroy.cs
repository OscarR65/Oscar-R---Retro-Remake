using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float Destroytime = 2;
    public GameObject Breakable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SetDestroyTime()
    {
        Destroy(gameObject, Destroytime);
    }
}
