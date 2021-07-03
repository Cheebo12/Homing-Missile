using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    
    public TextMeshProUGUI scoretext;
 
    private bool chk;
    float starttime;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    public void Update()
    {
        string textscore = scoring.points.ToString("0");
        scoretext.text = ""+textscore;
    }
}
