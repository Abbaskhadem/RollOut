using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocks : MonoBehaviour {


    public void OnMouseDown()
    {
        ScoringSys.myScore += 100;
        GetComponent<BoxCollider2D>().enabled = false;
        Destroy(gameObject, 5);
    }
}
