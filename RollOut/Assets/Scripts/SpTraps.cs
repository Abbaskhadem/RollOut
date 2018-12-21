using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpTraps : MonoBehaviour {
    public GameObject Tr1;
    public GameObject Tr2;
    float nextspawn = 0.0f;
    public GameObject SpawnerPoint;
    Vector2 whereTospawn;
    float roundX;
	// Use this for initialization
	void Start () {
        Instantiate(Tr1, SpawnerPoint.transform.position, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {

        
	}
}
