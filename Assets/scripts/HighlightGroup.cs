using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighlightGroup : MonoBehaviour {
    public Shader highlightShader;
    public RectTransform infoWindow;
    List<Shader> currShaders;
    //Shader[] currShader;

	// Use this for initialization
	void Start () {
        currShaders = new List<Shader>();
        highlightShader = FindObjectOfType<GlobalVars>().highlightShader;
        infoWindow = FindObjectOfType<GlobalVars>().infoWindow;
        foreach (Transform child in this.transform.parent.transform)
        {
            //child is your child transform
            Renderer renderer = child.GetComponent<Renderer>();
            if (renderer != null) currShaders.Add(renderer.material.shader);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseOver()
    {
        foreach (Transform child in this.transform.parent.transform)
        {
            child.GetComponent<Renderer>().material.shader = highlightShader;
            infoWindow.GetChild(0).GetComponent<Text>().text = "<b>" + this.transform.parent.GetComponent<BuildingData>().buildingName + "</b>\n\n";
            infoWindow.GetChild(0).GetComponent<Text>().text += this.transform.parent.GetComponent<BuildingData>().description;
            infoWindow.SetAsLastSibling();
            infoWindow.position = Input.mousePosition;
            infoWindow.gameObject.SetActive(true);
        }
    }
    private void OnMouseExit()
    {
        infoWindow.gameObject.SetActive(false);
        int i = 0;
        foreach (Transform child in this.transform.parent.transform)
        {
            child.GetComponent<Renderer>().material.shader = currShaders[i];
            i++;
        }
    }
}
