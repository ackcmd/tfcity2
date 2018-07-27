using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemInfo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
    public RectTransform itemInfo;
    private Item item;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Pointer enter at " + eventData.position);
        WorldPersistent worldPersistent = GameObject.FindObjectOfType<WorldPersistent>();
        int itemID = this.transform.parent.GetComponent<Cell>().itemID;
        if (itemID > -1)
        {
            item = worldPersistent.player.inventory[itemID];
        }
        else
        {
            worldPersistent.player.equipment.TryGetValue(this.transform.parent.GetComponent<Cell>().name, out item);
        }

        itemInfo.GetChild(0).GetComponent<Text>().text = "<b>"+item.itemname+"</b>\n\n";
        //itemInfo.GetChild(0).GetComponent<Text>().text += 
        foreach (KeyValuePair<string, int> entry in item.attributes)
        {
            // do something with entry.Value or entry.Key
            itemInfo.GetChild(0).GetComponent<Text>().text += entry.Key + " ";
            if (entry.Value > 0) itemInfo.GetChild(0).GetComponent<Text>().text += "<color=lime>";
            else itemInfo.GetChild(0).GetComponent<Text>().text += "<color=red>";
            itemInfo.GetChild(0).GetComponent<Text>().text += entry.Value + "</color>\n";
        }
        itemInfo.GetChild(0).GetComponent<Text>().text += "\n<color=yellow>"+item.description+"</color>";


    itemInfo.position = eventData.position;
        //itemInfo.GetChild(0).GetComponent<Text>().text = "Однажды в студеную зимнюю пору \nя из лесу вышел, был сильный мороз";
        itemInfo.SetAsLastSibling();
        itemInfo.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        itemInfo.gameObject.SetActive(false);
    }
}
