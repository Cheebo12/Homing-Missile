using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class startt : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Tappi;
    bool chk;
    // Start is called before the first frame update
    void Start()
    {
        Tappi.SetActive(true);
        Time.timeScale = 0f; 
    }

    // Update is called once per frame
    void Update()
    {
        if(chk)
        {
            if (Input.touchCount > 0)
            {
                Tappi.SetActive(false);
                Time.timeScale = 1f;
            }
            else if(Input.GetMouseButtonDown(0))
            {
                Tappi.SetActive(false);
                Time.timeScale = 1f;
            }
        }
    }
    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void startgame(){
        MainMenu.SetActive(false);
        chk = true;
    }
}
