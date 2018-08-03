﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highlight2 : MonoBehaviour {
    public Shader shader;
    private Shader[] oldshader;
    //private Material[] materials;
    // Use this for initialization
    void Start () {
        int i = 0;
        oldshader = new Shader[this.GetComponent<Renderer>().materials.Length];
        shader = FindObjectOfType<GlobalVars>().highlightShader;
        //oldshader = this.GetComponent<Renderer>().material.shader;
        //materials = this.GetComponent<Renderer>().materials;
        foreach (Material mat in this.GetComponent<Renderer>().materials)
        {
            oldshader[i] = mat.shader;
            i++;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseOver()
    {
        Renderer renderer = this.GetComponent<Renderer>();
        string parent = transform.parent.tag;
        //renderer.material.shader = shader;
        foreach (Material mat in renderer.materials)
        {
            mat.shader = shader;
        }
    }
    private void OnMouseExit()
    {
        //this.GetComponent<Renderer>().material.shader = oldshader;
        Renderer renderer = this.GetComponent<Renderer>();
        int i = 0;
        //renderer.materials = materials;
        foreach (Material mat in renderer.materials)
        {
            mat.shader = oldshader[i];
            i++;
        }
    }
}