using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item {

    //public string name = "filled";
    public string itemname;
    public string description = "Placeholder";
    public Dictionary<string, int> attributes = new Dictionary<string, int>();
    public bool usable = false;
    public bool equippable = false;
    public string equipmentslot = "none";
    public bool jinxed = false;
    public Sprite image; //=WorldPersistent.imageDefault;
    //public List<Effect> effects; reserved for future use
}
