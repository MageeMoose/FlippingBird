using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstecale : MonoBehaviour
{
    [SerializeField] Vector2 velocity = new Vector2(-4, 0);
    [SerializeField] float range = 4;
    
    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = velocity;
        transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
    }

    
    void Update()
    {
        
    }
}
