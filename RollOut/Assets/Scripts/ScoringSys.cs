using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSys : MonoBehaviour {
    public Text Score;
     float myTimer;
     float myScore ;
    // Use this for initialization
    void Start () {
       // myScore += 1;

    }
	
	// Update is called once per frame
	void Update () {
        
        myTimer = Time.deltaTime + myTimer;
       // myScore = Time.deltaTime + myTimer;
        if (myTimer >= 0.0001)
        {
           // myScore += 1;
           // myTimer = 0;
            myScore = Time.time *5+ myTimer;
            Score.text = myScore.ToString("f0");
            
        }

    }
}
