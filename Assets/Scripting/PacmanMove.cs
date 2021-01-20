using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanMove : MonoBehaviour
{
    public float speed = 0.4f;
    Vector2 dest = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        dest = transform.position;    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
        GetComponent<Rigidbody2D>().MovePosition(p);
        if (Input.GetKey(KeyCode.D)) {
            dest = (Vector2)transform.position + Vector2.right;
        }
        if (Input.GetKey(KeyCode.A)) {
            dest = (Vector2)transform.position + Vector2.left;
        }
        if (Input.GetKey(KeyCode.S)) {
            dest = (Vector2)transform.position - Vector2.up;
        }
        if (Input.GetKey(KeyCode.W)) {
            dest = (Vector2)transform.position - Vector2.down;
        }
        Vector2 dir = dest - (Vector2)transform.position; 
        GetComponent<Animator>().SetFloat("DirX", dir.x); 
        GetComponent<Animator>().SetFloat("DirY", dir.y);
    }
}
