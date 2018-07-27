using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileInfo : MonoBehaviour {
    public Text textbox;
    public MapData mapdata;
    public GameObject messagepanel;
    public Vector3 mousePos; //To store mouse position
    public Transform parentObj; //The UI Canvas
    public GameObject popupwindow; //The UI element I'm instantiating

    // Use this for initialization
    void Start ()
    {
        mapdata = FindObjectOfType(typeof(MapData)) as MapData;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(2))
        {
            //mousePos = Camera.main.WorldToScreenPoint(Input.mousePosition); //Gets mouse position
            //points += increment; //increases points variable by increment
            GameObject popup = (GameObject)GameObject.Instantiate(popupwindow, popupwindow.transform,false);
            
            Transform childTransform = popup.transform;
            childTransform.SetParent(parentObj);

            int xxx = 0;


                                                      /*RaycastHit hit;
                                                      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                                                      if (Physics.Raycast(ray, out hit))
                                                      {
                                                          textbox.text = mapdata.tiles[Mathf.FloorToInt(hit.point.x), Mathf.FloorToInt(hit.point.z)].name+"\n";
                                                          textbox.text += mapdata.tiles[Mathf.FloorToInt(hit.point.x), Mathf.FloorToInt(hit.point.z)].description + "\n";
                                                          messagepanel.SetActive(true);

                                                      }
                                          */
        }

    }
}
