﻿using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        

    }
    public void LoadSinglePlayerLevel()
    {
        Application.LoadLevel("Regret");
    }

    public void LoadMultiplayerLevel()
    {
        Application.LoadLevel("Ivory Tower");
    }

    public void toggleGameObject(GameObject gameObject)
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
