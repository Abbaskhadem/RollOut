using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheWheel : MonoBehaviour
{
    public static float Speed = 5f;
    public Rigidbody2D RbCharkh;
    void Update()
    {
        RbCharkh.velocity = new Vector2(Speed, 0f);
       // transform.Translate(Speed, 0, 0);
    }
}

