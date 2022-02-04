using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeBehav : MonoBehaviour
{
    public float x = 9f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        transform.position = new Vector2(transform.position.x-0.05f, transform.position.y);

        if (pos.x < -10)
        {
            var y = Random.Range(-3.88f, -4.99f);
            transform.position = new Vector2(x, y);
        }

        if (Input.GetKey("x"))
        {
            Application.Quit();
        }
    }
}
