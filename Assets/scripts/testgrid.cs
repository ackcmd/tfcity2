using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testgrid : MonoBehaviour {
    public Transform image;
    // Use this for initialization
    void Start () {
        
        Transform grid = this.transform.GetComponent<GridLayoutGroup>().transform;
        for (int x = 0; x < 80; x++)
        {
            Transform item = Instantiate(image, grid);
            item.name = "Cell"+x;
            item.localScale = new Vector3(1f, 1f,1f);
        }
        
    }

}
