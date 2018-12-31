using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swiping : MonoBehaviour {
    public float maxtime;
    public float minswipedist;

    public Animator Drop;
    float starttime;
    float endtime;
    float swipeDistans;
    float swipeTime;


    Vector3 startpos;
    Vector3 endpos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                starttime = Time.time;
                startpos = touch.position;

            }
           else if (touch.phase == TouchPhase.Ended)
            {
                endtime = Time.time;
                endpos = touch.position;

                swipeDistans = (endpos - startpos).magnitude;
                swipeTime = endtime - starttime;

                if (swipeTime < maxtime && swipeDistans > minswipedist)
                {
                    swipe();
                }

            }

        }
		
	}
   public void swipe()
    {
        Vector2 distans = endpos - startpos;
        if (Mathf.Abs(distans.x) > Mathf.Abs(distans.y))
        {


            if(distans.x > 0)
            {
                Debug.Log("right horizental swipe");
            }

           else if (distans.x < 0)
            {
                Drop.SetBool("Active", true);
                Debug.Log("leftt horizental swipe");
            }



           // Debug.Log("horizental");
        }

       else if (Mathf.Abs(distans.x) < Mathf.Abs(distans.y))
        {


            if (distans.y > 0)
            {
                
                Debug.Log("up vertical swipe");
            }

            else if (distans.y < 0)
            {
                Debug.Log("down vertical swipe");
            }


           // Debug.Log("vertical");
        }
    }
}
