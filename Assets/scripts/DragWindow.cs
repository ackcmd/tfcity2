using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragWindow : MonoBehaviour, IDragHandler, IBeginDragHandler
{
    private Vector2 offset=new Vector2(0f,0f);

    public void OnBeginDrag(PointerEventData eventData)
    {
        offset = (Vector2)this.transform.parent.transform.position - eventData.position;
    }


    public void OnDrag(PointerEventData eventData)
    {
        this.transform.parent.transform.position = eventData.position+offset;
    }

}
