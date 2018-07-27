using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldPersistent : MonoBehaviour
{
    public Player player;
    public Sprite imageDefault;
    private Item currItem=new Item();
    public Sprite helmet;
    public Sprite boots;

    public Dictionary<string, Image> itemImages;

    public int inventorySize=48;


    public void Awake()
    {
        this.player.equipment = new Dictionary<string, Item>();
        //this.player.equipment.Add("Boots", new Item());

        this.player.inventory = new Item[inventorySize];
        for (int i=0; i<inventorySize; i++)
        {
            this.player.inventory[i] = new Item();
        }
        //currItem.name = "filled";
        currItem.itemname = "helmet of awesomeness";
        currItem.description = "This helmet makes you awesome. Really awesome.";
        currItem.attributes.Add("pAttack", 10);
        currItem.attributes.Add("mAttack", 10);
        currItem.usable = false;
        currItem.equippable = true;
        currItem.equipmentslot = "HeadArmor";
        currItem.jinxed = false;
        currItem.image = helmet;

        //this.player.inventory.Add(currItem);
        this.player.inventory[0] = currItem;
        //this.player.inventory[0].name = "filled";
        currItem = new Item();

        currItem.itemname = "boots of badassness";
        currItem.description = "Now you are badass.";
        currItem.attributes.Add("pAttack", 10);
        currItem.attributes.Add("mAttack", 10);
        currItem.usable = false;
        currItem.equippable = true;
        currItem.equipmentslot = "Boots";
        currItem.jinxed = true;
        currItem.image = boots;

        this.player.inventory[3] = currItem;
        //this.player.inventory[3].name = "filled";
        //this.player = new Player();
        //this.player.inventory = new List<Item>();
    }

    public void RemoveItemFromPlayerInventory(int id)
    {
        this.player.inventory[id] = new Item();
        //GetComponent<InventoryWindow>().UpdateInventory();
    }

    public void AddItemToPlayerInventory(int id, Item item)
    {
        this.player.inventory[id] = item;
        //GetComponent<InventoryWindow>().UpdateInventory();
    }

    public void EquipItem(Item item)
    {
        if (player.equipment.ContainsKey(item.equipmentslot))
        {
            Unequip(item.equipmentslot);
            
        }
        player.equipment.Add(item.equipmentslot, item);
        //this.UpdateEquipment();
    }

    public bool Unequip(string slot)
    {
        for (int i=0; i< inventorySize; i++)
        {
            if (player.inventory[i].itemname == null)
            {
                player.inventory[i] = player.equipment[slot];
                player.equipment.Remove(slot);
                //this.UpdateEquipment();
                return (true);
            }
        }
        return (false);
    }

}
