using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.UI;

public class Brothel : MonoBehaviour
{
    public string EventToCatch;
    public GameObject npcOnEnter;
    RectTransform LocationWindow;
    RectTransform SecondaryText;
    GlobalVars globalvars;
    //public UnityAction action;

    private UnityAction someListener;

    void Awake()
    {
        someListener = new UnityAction(Enter);
        EventToCatch = this.transform.name;
    }

    void OnEnable()
    {
        EventManager.StartListening(EventToCatch, someListener);

    }

    void OnDisable()
    {
        EventManager.StopListening(EventToCatch, someListener);

    }

    void Enter()
    {
        //Debug.Log("Some Function was called!");
        globalvars = FindObjectOfType<GlobalVars>();
        LocationWindow = globalvars.LocationWindow;
        /*
        SecondaryText = globalvars.SecondaryText;
        foreach (Transform child in SecondaryText)
        {
            switch (child.name)
            {
                case "Header":
                    child.GetComponent<Text>().text = npcOnEnter.GetComponent<NPC>().npcName;
                    break;
                case "Text":
                    Text text = child.GetComponent<Text>();
                    text.text = npcOnEnter.GetComponent<NPC>().GetBasicInfo();
                    break;
            }
        }*/
        //LocationWindow.Find("SecondaryText").Find("Header").GetComponent<Text>().text = GetComponent<BuildingData>().buildingName;
        //LocationWindow.Find("SecondaryText").Find("Text").GetComponent<Text>().text = GetComponent<BuildingData>().ExtendedDescription;
        LocationWindow.SetAsLastSibling();
        LocationWindow.gameObject.SetActive(true);
        Component component = (NPC)npcOnEnter.GetComponent(npcOnEnter.name);
        
    }

}