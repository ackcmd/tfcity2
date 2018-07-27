using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragCell : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Transform place;
	// Use this for initialization
	void Start () {
		
	}

    public void OnDrag(PointerEventData pointerEventData)
    {
        this.transform.position = pointerEventData.position;
    }

    public void OnBeginDrag(PointerEventData pointerEventData)
    {
        this.place = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent.parent.parent);
        this.GetComponent<Image>().raycastTarget = false;
        this.GetComponent<DropZone>().enabled = false;
        //this.transform.gameObject.layer = 9;
        //this.transform.parent.GetComponent<CanvasGroup>().blocksRaycasts = false;
        ;
    }

    public void OnEndDrag(PointerEventData pointerEventData)
    {
        //this.transform.parent.GetComponent<CanvasGroup>().blocksRaycasts = true;
        //this.transform.gameObject.layer = 5;
        //this.GetComponent<Image>().raycastTarget = true;
        this.GetComponent<Image>().raycastTarget = true;
        this.GetComponent<DropZone>().enabled = true;
        this.transform.SetParent(this.place);
        this.transform.localPosition = new Vector3(0f,0f,0f);
        this.transform.parent.parent.parent.GetComponent<InventoryWindow>().UpdateInventory();
        this.transform.parent.parent.parent.GetComponent<InventoryWindow>().UpdateEquipment();
    }
}
