using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class testclick : MonoBehaviour, IPointerClickHandler
{
    private GridLayoutGroup grid;
    public Transform image;
    //public GameObject worldPersistent;
    //public GameObject gridlayout;


    public void OnPointerClick(PointerEventData eventData)
    {
        grid= this.transform.parent.GetComponent<GridLayoutGroup>();

        //Debug.Log(eventData.pointerPress.name);
        //Transform item = Instantiate(image, grid.transform);
        //item.SetParent(grid.transform, false);
        //if (eventData.button == PointerEventData.InputButton.Right) Debug.Log("Left click");
        
    }
}
