using HavanaRPG.Controller;
using HavanaRPG.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class City_Script : MonoBehaviour {

    public Location CurrentCity;
    public Text cityName; 

	// Use this for initialization
	void Start () {
        GameController.SetUIMenu();
        CurrentCity = ViewsController.CityToOpen;
        if (HavanaLib.IsEmpty(CurrentCity))
        {
            HavanaLib.MsgBox("Error loading city. Please contact the game support. [Error: CurrentCity is empty]");
            ViewsController.OpenNewCloseCurrent(ViewsController.LastViewName);
        }
    }
	
	// Update is called once per frame
	void Update () {
        GameController.RunGameTime();
    }
}
