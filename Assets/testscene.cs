using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testscene : MonoBehaviour {

    public string test;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int test0 ()
    {
        Debug.Log("test0");
        this.test1();
        return (0);
    }

    public int test1()
    {
        Debug.Log("test1");
        return (0);
    }
}
