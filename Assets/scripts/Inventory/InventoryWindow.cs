using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryWindow : MonoBehaviour {
    private WorldPersistent worldPersistent;
    //public Image imagePrefab;
    public RectTransform equipment;
    public RectTransform inventory;
    public RectTransform cellPrefab;
    public int inventorySize = 48;


	// Use this for initialization
	void Start () {
        worldPersistent = (WorldPersistent)GameObject.FindObjectOfType(typeof(WorldPersistent));
        inventorySize = worldPersistent.inventorySize;
        InitInventory(inventorySize);
        UpdateInventory();
        UpdateEquipment();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateEquipment()
    {
        int numOfCells = equipment.childCount;
        Item result;

        for (int i=0; i<numOfCells; i++)
        {
            if (worldPersistent.player.equipment.TryGetValue(equipment.GetChild(i).name, out result))
            {
                equipment.GetChild(i).GetChild(1).GetComponent<Image>().sprite = result.image;
                equipment.GetChild(i).GetChild(1).GetComponent<Image>().enabled = true;
            }
            else
            {
                equipment.GetChild(i).GetChild(1).GetComponent<Image>().enabled = false;
            }
        }
    }


    //Sync inventory window with player.inventory
    public void UpdateInventory()
    {
        int numOfCells = inventory.childCount;
        
        if (numOfCells != inventorySize) InitInventory(inventorySize);
        for (int i = 0; i<inventorySize; i++)
        {
            inventory.GetChild(i).GetComponent<Cell>().itemID = i;
            if (worldPersistent.player.inventory[i].itemname==null)
            {
                //inventory.GetChild(i).GetComponent<Cell>().itemID = -1;
                int count = inventory.GetChild(i).childCount;
                Image image = inventory.GetChild(i).GetChild(1).GetComponent<Image>();
                image.enabled = false;
                //RectTransform rect = (RectTransform)cell.GetChild(1);
                
                //Image img = inventory.GetChild(i).GetComponent("ItemImage");
            }
            else
            {
                
                inventory.GetChild(i).GetChild(1).GetComponent<Image>().sprite=worldPersistent.player.inventory[i].image;
                inventory.GetChild(i).GetChild(1).GetComponent<Image>().enabled = true;
            }
        }
        //Transform grid = this.transform.GetComponentInChildren<GridLayoutGroup>().transform;
        /*for(int x = 0; x<worldPersistent.player.inventory.Count; x++)
        {
            Item currItem = worldPersistent.player.inventory[x];
            //Image currImage = imagePrefab;
            currImage.sprite = currItem.image;
            Transform cell = Instantiate(currImage.transform, grid);
            cell.name = "Cell" + x;
        }*/
    }

    void InitInventory(int inventorySize)
    {
        foreach (Transform child in inventory)
        {
            GameObject.Destroy(child.gameObject);
        }

        for (int i=0; i<inventorySize; i++)
        {
            Transform cell = Instantiate(cellPrefab, inventory);
            cell.name = "Cell" + i;
            cell.GetChild(1).GetComponent<ItemInfo>().itemInfo = (RectTransform)GameObject.Find("ItemInfo").transform;
            //cell.GetComponent<Cell>().itemID=i;
        }
    }

}
