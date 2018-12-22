using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rocks : MonoBehaviour {
    public void OnMouseDown()
    {
        ScoringSys.Extra += 100;
        GetComponent<BoxCollider2D>().enabled = false;
        Destroy(gameObject, 5);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject)
        {
            GameManager.LoseGame = true;
        }
    }
}
