using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrothelWorker : NPC {
    RectTransform LocationWindow;
    RectTransform SecondaryText;
    GlobalVars globalvars;
    Dictionary<string, string> actions;

    void SetupActions()
    {
        
    }

    public void Interact(string action)
    {
        switch(action)
        {
            case "start":

                break;

            default:
                break;
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
