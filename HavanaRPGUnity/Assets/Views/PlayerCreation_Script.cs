using HavanaRPG.Controller;
using HavanaRPG.Model;
using HavanaRPG.Model.RpgClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCreation_Script : MonoBehaviour {

    InputField txt_charName;
    Dropdown cbx_class;
    Dropdown cbx_gender;
    Image img_class;
    Text lbl_classInfo;
    Text lbl_classDesc;
    RpgClass selectedCbxClass;
    string selectedCbxGender;

    // Use this for initialization
    void Start () {
        txt_charName = GameObject.Find("input_charName").GetComponent<InputField>();
        cbx_class = GameObject.Find("cbx_class").GetComponent<Dropdown>();
        cbx_gender = GameObject.Find("cbx_gender").GetComponent<Dropdown>();
        img_class = GameObject.Find("img_class").GetComponent<Image>();
        lbl_classInfo = GameObject.Find("lbl_classInfo").GetComponent<Text>();
        lbl_classDesc = GameObject.Find("lbl_classDesc").GetComponent<Text>();

        string[] enumClasses = Enum.GetNames(typeof(HavanaLib.ClassNames));
        string[] enumGenders = Enum.GetNames(typeof(HavanaLib.Gender));
        var listClasses = new List<string>(enumClasses);
        var listGenders = new List<string>(enumGenders);

        cbx_class.AddOptions(listClasses);
        cbx_gender.AddOptions(listGenders);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void btn_Back_Click()
    {
        Application.LoadLevel("StartMenu_View");
    }

    public void btn_start_Click()
    {
        if (ValidateFields())
        {
            string name = txt_charName.text;
            int classSelected = cbx_class.value;
            var _class = VerifyClassChoice(classSelected);

            int genderSelected = cbx_gender.value;
            var gender = VerifyGenderChoice(genderSelected);

            if (HavanaLib.ConfirmBox("Confirm?" + Environment.NewLine + Environment.NewLine + 
                "NAME:  " + HavanaLib.ToProperCase(name) + 
                "\nCLASS:  " + selectedCbxClass.ClassName + 
                "\nGENDER:  " + selectedCbxGender))
            {
                GameController.PerformStart(name, _class, gender);
            }
        }

    }

    private bool ValidateFields()
    {
        if (HavanaLib.IsEmpty(txt_charName.text))
        {
            HavanaLib.MsgBox("Name is Empty!");
            return false;
        }
        else if (txt_charName.text.Length < 3)
        {
            HavanaLib.MsgBox("Name is too short!");
            return false;

        }

        if (HavanaLib.IsEmpty(cbx_class.value) || cbx_class.value.ToString() == "0")
        {
            HavanaLib.MsgBox("Please, choose a class.");
            return false;
        }

        if (HavanaLib.IsEmpty(cbx_gender.value) || cbx_gender.value.ToString() == "0")
        {
            HavanaLib.MsgBox("Please, choose a gender.");
            return false;
        }

        return true;
    }    

    public void OnClassIndexChange()
    {
        var index = cbx_class.value;
        VerifyClassChoice(index);
        lbl_classInfo.text = selectedCbxClass.ToString();
        lbl_classDesc.text = selectedCbxClass.ToDescription();
        img_class.sprite = selectedCbxClass.ImgSource;
    }

    private HavanaLib.ClassNames VerifyClassChoice(int index) {
        switch (index)
        {
            case 1: //warrior
                selectedCbxClass = new WarriorClass();
                return HavanaLib.ClassNames.Warrior;

            case 2: //Sorcerer
                selectedCbxClass = new SorcererClass();
                return HavanaLib.ClassNames.Sorcerer;

            case 3: //druid
                selectedCbxClass = new DruidClass();
                return HavanaLib.ClassNames.Druid;

            case 4: //paladin
                selectedCbxClass = new PaladinClass();
                return HavanaLib.ClassNames.Paladin;

            case 5: //archer
                selectedCbxClass = new ArcherClass();
                return HavanaLib.ClassNames.Archer;

            case 6: //monk
                selectedCbxClass = new MonkClass();
                return HavanaLib.ClassNames.Monk;

            case 7: //thief
                selectedCbxClass = new ThiefClass();
                return HavanaLib.ClassNames.Thief;

            default:
                selectedCbxClass = new RpgClass();
                return HavanaLib.ClassNames.None;
        }
    }
    private HavanaLib.Gender VerifyGenderChoice(int index)
    {
        switch (index)
        {
            case 1: //male
                selectedCbxGender = "Male";
                return HavanaLib.Gender.Male;

            case 2: //female
                selectedCbxGender = "Female";
                return HavanaLib.Gender.Female;
                            
            default:
                selectedCbxGender = "None";
                return HavanaLib.Gender.None;
        }
    }

}
