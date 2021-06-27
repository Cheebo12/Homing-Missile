using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class realisticMove : MonoBehaviour
{
   
   public Transform Target;
    private Rigidbody2D rb;
    public float speed;
    public float rotatespeed;
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
    private int r;
    void Start()
    {
        r = Random.Range(0,2);
        Debug.Log(r);
        rb = GetComponent<Rigidbody2D>();
        speed  = Random.Range(250f, 500f);
        rotatespeed  = Random.Range(500f, 1000f);
        arax = new float[n];
        aray = new float[n];
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
       if(r==1){ 

        if(Target != null){    
        Vector2 direction = (Vector2)Target.position - rb.position;
       speed  = 400f;
        rotatespeed = 200f;
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
       }else{
           rb.velocity = Vector2.zero;
        rb.angularVelocity = 0f;
       }
      //  Quaternion torotate = Quaternion.LookRotation(Vector3.forward, rb.velocity);
       // transform.rotation = Quaternion.RotateTowards(transform.rotation, torotate, rotationspeed*Time.deltaTime);
    }else{
        if(Target != null){   
        Vector2 direction = (Vector2)Target.position - rb.position;

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
}
