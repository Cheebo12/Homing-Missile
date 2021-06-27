using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnning : MonoBehaviour
{   private float timer = 0;
    private float maxtime = 10f;
    public GameObject missile;
    

 
    private float y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxtime){
            y = Random.Range(5.80f, 1.79f); 
            GameObject newmissile = Instantiate(missile);
            newmissile.transform.position = transform.position;
            timer = 0;
            FindObjectOfType<AudioManager>().Play("fire");
        } 
        timer += Time.deltaTime; 
    }
    
    
    
}
