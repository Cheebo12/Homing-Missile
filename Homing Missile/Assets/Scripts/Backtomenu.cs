using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Backtomenu : MonoBehaviour
{
    public Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
        StartCoroutine(LoadLevelAfterDelay());
    }

   IEnumerator LoadLevelAfterDelay()
     {
         anim.Play("scrolling");
         Debug.Log("Wait");
         yield return new WaitForSeconds(5);
        Debug.Log("Done");
        SceneManager.LoadScene("Main Menu");
     }
}
