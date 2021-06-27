using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject restartMenu;
    // Start is called before the first frame update
    void Start()
    {
        restartMenu.SetActive(false);
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "target1")
    {
        FindObjectOfType<AudioManager>().Play("explode");
        Destroy(collision.gameObject);
        Destroy(gameObject);
        restartMenu.SetActive(true);
    }
    }
}
