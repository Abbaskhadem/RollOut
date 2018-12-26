using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static bool LoseGame = false;
    public static bool GameStarted = false;
    public static bool Go = false;
    public GameObject MenuCamera;
    public GameObject Starter;
    public GameObject MainCamera;
    public GameObject Sky;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(GameStarted==true)
        {
            Starter.GetComponent<BoxCollider2D>().enabled = false;
            MenuCamera.GetComponent<Camera>().enabled = false;
            MainCamera.GetComponent<Camera>().enabled = true;
            Sky.SetActive(false);
        }
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject)
        {
            
            GameStarted = true;
        }
    }
    public void StartGame()
    {
        Go = true;
    }
}
