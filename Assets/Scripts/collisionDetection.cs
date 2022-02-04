using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetection : MonoBehaviour
{
    public Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var up = Vector2.up;

        if (Input.GetKey("w") || Input.GetKey("space"))
            player.AddForce(up*10);
    }
}
