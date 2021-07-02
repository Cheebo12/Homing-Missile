using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    public TextMeshProUGUI scoretext;
 
    private bool chk;
    float starttime;
    public score a;
    // Start is called before the first frame update
    void Start()
    {
        a = FindObjectOfType<score>();
    }

    // Update is called once per frame
    public void Update()
    {
        float ais = a.points;
    }
}
