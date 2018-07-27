using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_highlight : MonoBehaviour {
    public Shader shader;
    private Shader oldshader;
	// Use this for initialization
	void Start () {
        oldshader = this.GetComponent<Renderer>().material.shader;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseOver()
    {
        
        this.GetComponent<Renderer>().material.shader = shader;
    }
    private void OnMouseExit()
    {
        this.GetComponent<Renderer>().material.shader = oldshader;
    }
}
