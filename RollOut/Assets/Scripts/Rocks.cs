using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocks : MonoBehaviour {
    public static bool LoseGame=false;

    public void OnMouseDown()
    {
        ScoringSys.myScore += 100;
        GetComponent<BoxCollider2D>().enabled = false;
        Destroy(gameObject, 5);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject)
        {
            LoseGame = true;
        }
    }
}
