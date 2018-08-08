using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testlocation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Enter()
    {
        Transform test = this.transform.Find("Scene");
        test.GetComponent<testscene>().test0();
    }
}
