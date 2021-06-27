using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homing : MonoBehaviour
{   
    
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float rotatespeed;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
      
        speed  = Random.Range(250f, 500f);
        rotatespeed  = Random.Range(500f, 1000f);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     if(target != null){   
        Vector2 direction = (Vector2)target.position - rb.position;

        direction.Normalize();

        float rotateamount = Vector3.Cross(direction, transform.up).z;

        rb.angularVelocity = -rotateamount * rotatespeed;

        rb.velocity = transform.up * speed * Time.deltaTime;
     }else{
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0f;
     }
    }
}
