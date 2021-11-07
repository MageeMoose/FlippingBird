using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdy : MonoBehaviour
{
    Rigidbody2D rb2d;
    

    [SerializeField]float gravitySpeed = 1f;
    [SerializeField]float gravitySpeedUp = -1f;
    [SerializeField]float rotationAngelUp = 20f;
    [SerializeField]float rotationAngelDown = -20f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 euler = transform.eulerAngles;
        if(euler.z > 180) euler.z = euler.z - 360;

        euler.z = Mathf.Clamp(euler.z, -20, 20);
        transform.eulerAngles = euler;

        if(Input.GetKey(KeyCode.UpArrow))
        {
            rb2d.gravityScale = gravitySpeedUp;
            transform.Rotate(0,0,rotationAngelUp);
        }
        else
        {
            rb2d.gravityScale = gravitySpeed;
            transform.Rotate(0,0,rotationAngelDown);
        }
    }
}
