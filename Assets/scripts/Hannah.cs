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
    int selectedWorker = 0;

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

            case "standart":
                StandartSevice();
                break;

            case "next":
                NextWorker();
                break;

            case "previous":
                PreviousWorker();
                break;

            case "select":
                SelectWorker();
                break;

            default:
                StartDialogue();
                break;
        }
        return (0);
    }

    private void SelectWorker()
    {
        workers[selectedWorker].GetComponent<BrothelWorker>().Interact("Start");
    }

    private void PreviousWorker()
    {
        selectedWorker--;
        if (selectedWorker <0) selectedWorker = workers.Count-1;
        ShowWorker(selectedWorker);
    }

    private void NextWorker()
    {
        selectedWorker++;
        if (selectedWorker > workers.Count-1) selectedWorker = 0;
        ShowWorker(selectedWorker);
    }

    private void ShowWorker(int worker)
    {
        globalvars = FindObjectOfType<GlobalVars>();
        LocationWindow = globalvars.LocationWindow;
        SecondaryText = globalvars.SecondaryText;
        foreach (Transform child in SecondaryText)
        {
            switch (child.name)
            {
                case "Header":
                    child.GetComponent<Text>().text = workers[selectedWorker].GetComponent<BrothelWorker>().npcName;
                    break;
                case "Text":
                    Text text = child.GetComponent<Text>();
                    text.text = workers[selectedWorker].GetComponent<BrothelWorker>().npcDescription +"\n";
                    Dictionary<string, string> skills = workers[selectedWorker].GetComponent<BrothelWorker>().GetSexSkillsBasicTxt();
                    foreach (KeyValuePair<string, string> skill in skills)
                    {
                        text.text += skill.Key + ": " + skill.Value + "\n";
                    }
                    break;
            }
        }
        globalvars.MainImage.GetComponent<Image>().sprite = workers[selectedWorker].GetComponent<BrothelWorker>().npcAvatar;
    }

    private void StandartSevice()
    {
        selectedWorker = 0;
        ShowWorker(selectedWorker);
        actions = new Dictionary<string, string>();
        actions.Add("previous", "Show previous");
        actions.Add("next", "Show Next");
        actions.Add("select", "Select");
        actions.Add("cancel", "Cancel");
        SetupActions(actions);
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
        this.Init();
        this.transform.parent.GetComponent<BuildingManager>().defaultAction = Interact;
        workers = new List<GameObject>();
        foreach (Transform child in this.transform.parent.transform)
        {
            if (child.tag == "worker") workers.Add(child.gameObject);
            //GameObject.Destroy(child.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {

    }
}
