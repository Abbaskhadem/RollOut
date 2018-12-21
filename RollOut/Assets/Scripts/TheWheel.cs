using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheWheel : MonoBehaviour
{
    public  float Speed =5;
    public Rigidbody2D RbCharkh;
   public float timer = 5f;
    public float TotalTime = 0f;
    Vector3 lastPos;
    
    void Update()
    {

        TotalTime = Time.deltaTime + TotalTime;
        if (TotalTime >= timer)
        {
            Speed += 1f;
            TotalTime = 0;

        }

        RbCharkh.velocity = new Vector2(Speed, 0f);
        //Speed += Time.deltaTime;
        // transform.Translate(Speed, 0, 0);
    }
}

