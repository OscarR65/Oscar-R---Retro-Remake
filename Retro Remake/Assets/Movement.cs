using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode left = KeyCode.A, right = KeyCode.D, up = KeyCode.W, down = KeyCode.S, jump = KeyCode.W;
    public float speed = 10, jumpHeight = 15;

    private Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Input.GetKey() for holding a key
        // Input.GetKeyUp() for pressing a key
        // Input.GetKeyDown() for releasing a key

        if (Input.GetKey(left)) //check for the player HOLDING DOWN the left button
        {
            // Get the gameobject rigidbody2D component and set its velocity to be to the left at the given speed
            _rb.velocity = Vector2.left * speed;
        }
        
        if (Input.GetKey(right)) //check for the player HOLDING DOWN the right button
        {
            // Get the gameobject rigidbody2D component and set its velocity to be to the right at the given speed
            _rb.velocity = Vector2.right * speed;
        }
        
        if (Input.GetKey(up)) //check for the player HOLDING DOWN the up button
        {
            // Get the gameobject rigidbody2D component and set its velocity to be to the up at the given speed
           _rb.velocity = Vector2.up * speed;
        }
        
        if (Input.GetKey(down)) //check for the player HOLDING DOWN the down button
        {
            // Get the gameobject rigidbody2D component and set its velocity to be to the down at the given speed
            _rb.velocity = Vector2.down * speed;
        }

        if (Input.GetKeyDown(jump)) //check for the player pressing the jump button
        {
            // Get the gameobject rigidbody2D component and set its velocity to be to the up at the given jumpheight
            _rb.velocity = Vector2.up * jumpHeight;
        }







    }
}
