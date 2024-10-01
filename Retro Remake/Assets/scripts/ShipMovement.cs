using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ShipMovement : MonoBehaviour
{
    public float moveSpeed;
    public int enemyCount;

    // Start is called before the first frame update
    void Awake()
    {
        ShipSpawner.enemiesLeft += enemyCount;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boundary")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
            moveSpeed *= -1;
        }

        if(transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }
}
