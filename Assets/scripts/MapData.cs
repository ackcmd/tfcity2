using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{
    public string name;
    public string description;
    //public List<NPC> residents;
}

public class MapData : MonoBehaviour
{
    public float[,] mapdata = new float[10,10];
    public Tile[,] tiles = new Tile[10,10];

    void Awake()
    {
        //tilesmap = new float[sizex, sizey];
        for (int xx = 0; xx < 10; xx++)
        {
            for (int yy = 0; yy < 10; yy++)
            {
                mapdata[xx, yy] = 5f;
                tiles[xx, yy] = new Tile();
                tiles[xx, yy].name = "Tile" + " " + xx + " " + yy;
                tiles[xx, yy].description = "Description" + " " + xx + " " + yy;
            }
        }

        for (int xx = 0; xx < 2; xx++)
        {
            for (int yy = 0; yy < 5; yy++)
            {
                mapdata[xx, yy] = 20f;
            }
        }

        for (int xx = 8; xx < 10; xx++)
        {
            for (int yy = 0; yy < 5; yy++)
            {
                mapdata[xx, yy] = 20f;
            }
        }

        for (int xx = 2; xx < 8; xx++)
        {
            for (int yy = 3; yy < 5; yy++)
            {
                mapdata[xx, yy] = 20f;
            }
        }

        for (int xx = 0; xx < 10; xx++)
        {
            for (int yy = 6; yy < 10; yy++)
            {
                mapdata[xx, yy] = 20f;
            }
        }

        mapdata[5, 3] = 5f;
        mapdata[5, 4] = 5f;
        mapdata[3, 6] = 5f;
        mapdata[3, 7] = 5f;
        mapdata[3, 8] = 5f;
        mapdata[3, 9] = 5f;
        mapdata[6, 6] = 5f;
        mapdata[6, 7] = 5f;
        mapdata[6, 8] = 5f;
        mapdata[6, 9] = 5f;
    }

    // Use this for initialization
    void Start()
    { 
    
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
