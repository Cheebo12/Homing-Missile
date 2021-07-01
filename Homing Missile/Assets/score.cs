using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    public TextMeshProUGUI scoretext;
    float points = 0;
    private bool chk;
    float starttime;
    // Start is called before the first frame update
    void Start()
    {
        starttime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            chk = true;
        }
        else if(Input.GetMouseButtonDown(0)){
            chk = true;
        }

        if(chk){
            if(target != null){
            points = Time.time-starttime;
            string textscore = points.ToString("0");
            scoretext.text = "Time: "+textscore;
            }
        }
        
    }
}
