using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class Hannah : NPC {

    
    RectTransform LocationWindow;
    RectTransform SecondaryText;
    GlobalVars globalvars;
    Dictionary<string, string> actions;
    List<GameObject> workers;

    int Interact (string command)
    {
        Debug.Log(command);
        switch (command)
        {
            case "StartDlg":
                StartDialogue();
                break;

            case "exit":
                ExitDialogue();
                break;

            case "smalltalk":
                SmallTalk();
                break;
        }
        return (0);
    }

    private void SmallTalk()
    {
        globalvars = FindObjectOfType<GlobalVars>();
        LocationWindow = globalvars.LocationWindow;
        globalvars.MainText.GetComponent<Text>().text = "This weather is crazy! It was cold yesterday and today I came in with an open jacket. I hope it stays warm, don’t you?";
        actions = new Dictionary<string, string>();
        actions.Add("smalltalk", "Small talk");
        actions.Add("quest", "Quest");
        actions.Add("standart", "Standart service");
        actions.Add("elite", "Elite service");
        actions.Add("exit", "Exit");
        SetupActions(actions);
    }

    void ExitDialogue()
    {
        globalvars = FindObjectOfType<GlobalVars>();
        LocationWindow = globalvars.LocationWindow;
        LocationWindow.gameObject.SetActive(false);
    }

    int StartDialogue()
    {
        int returnValue = 0;

        globalvars = FindObjectOfType<GlobalVars>();
        LocationWindow = globalvars.LocationWindow;
        SecondaryText = globalvars.SecondaryText;
        foreach (Transform child in SecondaryText)
        {
            switch (child.name)
            {
                case "Header":
                    child.GetComponent<Text>().text = npcName;
                    break;
                case "Text":
                    Text text = child.GetComponent<Text>();
                    text.text = GetBasicInfo();
                    break;
            }
        }
        globalvars.MainImage.GetComponent<Image>().sprite = this.npcAvatar;
        globalvars.MainText.GetComponent<Text>().text = "Hello, {playertitle} {playername}! Nice to see you again! If we can help you in ANY way possible, just let me know.";
        actions = new Dictionary<string, string>();
        actions.Add("smalltalk","Small talk");
        actions.Add("quest", "Quest");
        actions.Add("standart", "Standart service");
        actions.Add("elite", "Elite service");
        actions.Add("exit", "Exit");
        SetupActions(actions);
        return (returnValue);
    }

    void SetupActions(Dictionary<string, string> actions)
    {
        globalvars = FindObjectOfType<GlobalVars>();
        ClearActionArea();
        //actions = new Dictionary<string, string>();
        foreach (KeyValuePair<string, string> action in actions)
        {
            GameObject Button = GameObject.Instantiate(globalvars.buttonPrefab) as GameObject;
            Button.transform.SetParent(globalvars.ActionArea.transform);
            Button.GetComponentInChildren<Text>().text = action.Value;
            //Button.GetComponent<ButtonData>().param = action.Key;
            Button.transform.localScale = new Vector3(1,1,1);
            Button.GetComponent<Button>().onClick.AddListener(delegate { Interact(action.Key); });
        }
    }

    void ClearActionArea()
    {
        foreach (Transform child in globalvars.ActionArea.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }

	// Use this for initialization
	void Start () {
        //this.transform.parent.GetComponent<BuildingManager>().defaultAction = StartDialogue;
        this.transform.parent.GetComponent<BuildingManager>().defaultAction = Interact;
        workers = new List<GameObject>();
        foreach (Transform child in this.transform.parent.transform)
        {
            if (child.tag == "worker") workers.Add(child.gameObject);
            //GameObject.Destroy(child.gameObject);
        }
        Opinion = opinion1; //opinion on player 0-10

        //base stats
        Rank = rank1;
        //0 - slave
        //1 - freeman
        //2 - citizen
        //3 - noble
        //4 - legend

        Strenght = strenght1; //0-10
        Dexterity = dexterity1;//0-10
        Constitution = constitution1;//0-10

        Intellect = intellect1;//0-10
        Arcane = arcane1;//0-10
        Willpower = willpower1;//0-10

        //special stats
        Dominance = dominance1;//0-100
        Obedience = obedience1;//0-100

        //common skills
        Housekeeping = housekeeping1;//0-100
        Cooking = cooking1;//0-100
        Nurse = nurse1;//0-100
        Secretary = secretary1;//0-100
        Alchemy = alchemy1;//0-100
        Etiquette = etiquette1;//0-100
        Martial = martial1;//0-100
        Fitness = fitness1;//0-100
        Dance = dance1;//0-100
        Singing = singing1;//0-100
        Music = music1;//0-100
        Petplay = petplay1;//0-100
        Magic = magic1;//0-100
        Mentor = mentor1;//0-100

        //sex skills

        Handjob = handjob1;//0-100
        Footjob = footjob1;//0-100
        Titjob = titjob1;//0-100
        Rubbing = rubbing1;//0-100

        Kissing = kissing1;//0-100
        Licking = licking1;//0-100
        Blowjob = blowjob1;//0-100
        Rimming = rimming1;//0-100

        Vaginal_r = vaginal_r1;//0-100
        Anal_r = anal_r1;//0-100
        Vaginal_g = vaginal_g1;//0-100
        Anal_g = anal_g1;//0-100

        Twosome = twosome1;//0-100
        Threesome = threesome1;//0-100
        Gangbang = gangbang1;//0-100
        Bukkake = bukkake1;//0-100

        Seduction = seduction1;//0-100
        Masturbation = masturbation1;//0-100
        Selfhumiliation = selfhumiliation1;//0-100

        Bondage = bondage1;//0-100
        Domination = domination1;//0-100
        Torture = torture1;//0-100

        Selfbondage = selfbondage1;//0-100
        Submission = submission1;//0-100
        Masochism = masochism1;//0-100

        G_shower = g_shower1;//0-100
        Scat = scat1;//0-100
        Zoo = zoo1;//0-100
        Fisting = fisting1;//0-100   

    }
	
	// Update is called once per frame
	void Update () {

    }
}
