using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSys : MonoBehaviour {
    public Text Score;
    float myTimer;
    public static float myScore ;
    public static float Extra;
    // Use this for initialization
    void Start () {
       // myScore += 1;

    }
	
	// Update is called once per frame
	void Update () {
        if(GameManager.LoseGame==false)
        {
            myTimer = Time.deltaTime + myTimer;
            if (myTimer >= 0.0001)
            {
                myScore = myTimer+ Extra;
                Score.text = myScore.ToString("f0");

            }
        }
   

    }
}
