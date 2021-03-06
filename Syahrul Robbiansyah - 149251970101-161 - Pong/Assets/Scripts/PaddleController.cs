using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
     public int speed;
     public KeyCode upkey;
     public KeyCode downkey;
     private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MoveObject(GetInput());
    }

    // input
    private Vector2 GetInput()
    {
        

        if (Input.GetKey(upkey))
        {
            return Vector2.up * speed; // up movement
        }
        else if (Input.GetKey(downkey))
        {
            return Vector2.down * speed; // down movement
        }

        return Vector2.zero;

    }

    // object movement using input
    private void MoveObject(Vector2 movement)
    {
        Debug.Log("Paddle Speed: " + movement);
        rig.velocity = movement;
    }
}
