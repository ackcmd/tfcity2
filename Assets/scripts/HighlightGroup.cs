using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightGroup : MonoBehaviour {
    public Shader highlightShader;
    List<Shader> currShaders;
    //Shader[] currShader;

	// Use this for initialization
	void Start () {
        currShaders = new List<Shader>();
        highlightShader = FindObjectOfType<GlobalVars>().highlightShader;
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
        }
    }
    private void OnMouseExit()
    {
        int i = 0;
        foreach (Transform child in this.transform.parent.transform)
        {
            child.GetComponent<Renderer>().material.shader = currShaders[i];
            i++;
        }
    }
}
