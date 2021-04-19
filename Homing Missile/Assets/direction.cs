using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class direction : MonoBehaviour
{
    private Vector3 movementDirection;
    public GameObject alien;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector3(Random.Range(-1.0f, 1.0f), 0,Random.Range(-1.0f, 1.0f)).normalized;
    
        alien.transform.rotation = Quaternion.LookRotation (movementDirection);    
    }


}
