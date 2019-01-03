using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivator : MonoBehaviour {
    public GameObject Activatorss;
    public GameObject Deactivatorss;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag=="Swamp")
        {
            Deactivatorss.GetComponent<BoxCollider2D>().isTrigger = true;
            Activatorss.GetComponent<BoxCollider2D>().isTrigger = false;
            Debug.Log("false");
            Activator.Activated = false;
        }
    }
}
