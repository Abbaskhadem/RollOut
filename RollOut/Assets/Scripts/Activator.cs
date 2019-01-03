using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour {
    public GameObject Activatorss;
    public GameObject Deactivatorss;
    public static bool Activated=false;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag=="Swamp")
        {
            Deactivatorss.GetComponent<BoxCollider2D>().isTrigger = false;
            Activatorss.GetComponent<BoxCollider2D>().isTrigger = true;
            Debug.Log("true");
           Activated = true;
        }
    }
}
