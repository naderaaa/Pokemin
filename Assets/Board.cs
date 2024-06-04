using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Board : MonoBehaviour
{
    public GameObject[][] tiles;
    public GameObject tilePrefab;

    void Start()
    {
        for (int x = 0; x < 9; x++) 
        {
            for (int y = 0; y < 9; y++)
            {
                GameObject tileObj = GameObject.Instantiate(tilePrefab, gameObject.transform);
                Tile tile = tileObj.GetComponent<Tile>();
            
                
                tile.posx = x;
                tile.posy = y;
                tile.PosGeneration();
                
              
            }
        }
    }
}
