using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public Transform Target;
    private Rigidbody2D rb;
    public float speed = 5f;
    public float rotatespeed = 200f;
    private float[] arax;
    private float[] aray;
    private float delta;
    private float predictedx;
    private bool flag = false;
    private int count=0;
    private int prev = 0;
    public int n = 100;
    private int current=0;
    private float predictedy;
    [SerializeField]
    private float rotationspeed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        arax = new float[n];
        aray = new float[n];
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        Vector2 direction = (Vector2)Target.position - rb.position;
        
       for (int i = 0; i < n; i++)
       {    
        
        arax[i] = direction.x;
        aray[i] = direction.y;
                       
        if(flag & count > 50){       
        if(current == n-1){
            current = 0;
        }
        // delta = arax[prev] - arax[current]; 
        // predictedx = arax[current] + delta;   

        // predictedy = aray[prev] + ((predictedx - arax[prev])/(arax[current]-arax[prev])*(aray[current]-aray[prev]));

        direction.Normalize();
        direction.Set(arax[prev],aray[prev]);
        
        prev++;
        if(prev == n-1){
            prev = 0;
        }
         
        float rotateAmount = Vector3.Cross(direction, transform.up).z;
        rb.angularVelocity = -rotateAmount * rotatespeed;
        rb.velocity = transform.up* speed * Time.deltaTime;
        }
        flag = true;
        count++;
        current++;
       }
      //  Quaternion torotate = Quaternion.LookRotation(Vector3.forward, rb.velocity);
       // transform.rotation = Quaternion.RotateTowards(transform.rotation, torotate, rotationspeed*Time.deltaTime);
    }
}
