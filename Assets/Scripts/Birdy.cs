using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Birdy : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] Vector2 jumpForce = new Vector2(0, 300);

    // [SerializeField]float gravitySpeed = 1f;
    // [SerializeField]float gravitySpeedUp = -1f;
    // [SerializeField]float rotationAngelUp = 20f;
    // [SerializeField]float rotationAngelDown = -20f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp("space"))
        {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(jumpForce);
        }

        // Vector3 euler = transform.eulerAngles;
        // if(euler.z > 180) euler.z = euler.z - 360;

        // euler.z = Mathf.Clamp(euler.z, -20, 20);
        // transform.eulerAngles = euler;

        // if(Input.GetKey(KeyCode.UpArrow))
        // {
        //     rb2d.gravityScale = gravitySpeedUp;
        //     transform.Rotate(0,0,rotationAngelUp);
        // }
        // else
        // {
        //     rb2d.gravityScale = gravitySpeed;
        //     transform.Rotate(0,0,rotationAngelDown);
        // }
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Die();    
    }

    void Die()
    {
        SceneManager.LoadScene(0);
    }

}
