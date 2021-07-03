using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class startt : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Tappi;
    bool chk;
    float chk2;
    bool chk3 = true;
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
            for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                starttouchs();
            }
        }
            if(Input.GetMouseButtonDown(0))
            {
                Tappi.SetActive(false);
                Time.timeScale = 1f;
            }
        }
    }
    private void starttouchs()
    {
        Tappi.SetActive(false);
        Time.timeScale = 1f;
    }
    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void startgame(){
        MainMenu.SetActive(false);
        chk = true;
    }
    public void credits(){
        SceneManager.LoadScene("credits");
    }
}
