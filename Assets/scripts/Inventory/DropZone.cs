using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler {
    WorldPersistent worldPersistent;
    public string EqSlot;
    object slotName;

    private enum equipmentSlots {HeadArmor, HeadAccessory, TopArmor, TopAccessory, LowerArmor, LowerAccessory, LegAccessory, Boots };

	// Use this for initialization
	void Start () {
        worldPersistent = (WorldPersistent)GameObject.FindObjectOfType(typeof(WorldPersistent));
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnDrop(PointerEventData pointerEventData)
    {
        Transform oldplace = pointerEventData.pointerDrag.GetComponent<DragCell>().place;
        Cell oldslot = oldplace.GetComponent<Cell>();
        int old = oldslot.itemID;

        slotName = gameObject.transform.parent.name;
        if (old < 0 && (this.transform.name != "Equipment" || !Enum.IsDefined(typeof(equipmentSlots), slotName)))
        {
            worldPersistent.Unequip(oldslot.name);
        }
        else
        {
            if (Enum.IsDefined(typeof(equipmentSlots), slotName) && old > -1) //if equippable item dropped to equipment slot
            {
                Debug.Log("Special slot\n");
                worldPersistent.EquipItem(worldPersistent.player.inventory[old]);
                worldPersistent.RemoveItemFromPlayerInventory(old);
            }
            else
            {
                Debug.Log("drop" + gameObject.transform.parent.name);
                int newslot = this.transform.parent.GetComponent<Cell>().itemID;

                worldPersistent.AddItemToPlayerInventory(
                    newslot,
                    worldPersistent.player.inventory[old]
                    );
                worldPersistent.RemoveItemFromPlayerInventory(old);
                //this.transform.parent.parent.parent.GetComponent<InventoryWindow>().UpdateInventory();
                //DragCell cell = pointerEventData.pointerDrag.GetComponent<DragCell>();
                //if (cell != null) cell.place = this.transform.parent;
            }
        }
    }
}
