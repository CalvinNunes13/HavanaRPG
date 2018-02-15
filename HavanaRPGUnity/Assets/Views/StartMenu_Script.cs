using HavanaRPG.Controller;
using HavanaRPG.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu_Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ViewsController.LoadAllSceneToArray();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // --------- MAIN MENU ------------------//
    public void StartGameClick()
    {
        GameController.StartGame();
    }

    public void ExitGameClick()
    {
        GameController.ExitGame();
    }
    // ----------- FIM MAIN MENU --------------//


}
