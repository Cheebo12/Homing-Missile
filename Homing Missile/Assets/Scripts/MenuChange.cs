using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuChange : MonoBehaviour
{   
    [SerializeField]
    private GameObject mainmenu;
    [SerializeField]
    private GameObject instruction;
    // Start is called before the first frame update
    void Start()
    {
        mainmenu.SetActive(true);
    }

    public void Instructions()
    {
        mainmenu.SetActive(false);
        instruction.SetActive(true);
    }

    public void MainMenu()
    {
        instruction.SetActive(false);
        mainmenu.SetActive(true);
    }

    public void Quit(){
        Application.Quit();
    }
}
