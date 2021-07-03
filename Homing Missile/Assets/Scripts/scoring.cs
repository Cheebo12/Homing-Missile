using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoring : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    public TextMeshProUGUI scoretext;
    public static float points = 0;
    private bool chk;
    float starttime;
    public float ss=0;
    // Start is called before the first frame update
    void Start()
    {
        starttime = Time.time;
    }

    // Update is called once per frame
    public void Update()
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
            scoretext.text = "Score: "+textscore;
            ss = getScore(points);
            }
        }
        
    }

    public float getScore(float points){
        return points;    
    }
}
