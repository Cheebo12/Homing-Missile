using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class startt : MonoBehaviour
{
    public GameObject pauseMenuUI;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<DragFingerMove>();
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            
        }
        else if(Input.GetMouseButtonDown(0)){
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
        }
    }
    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
