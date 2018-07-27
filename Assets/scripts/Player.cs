using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Item[] inventory;
    public Dictionary<string, Item> equipment;
    public Dictionary<string, int> attributes;
    public int money;
    //public List<Effect> effects;// reserved for future use
    //public List<Perk> perks; // reserved for future use

}
