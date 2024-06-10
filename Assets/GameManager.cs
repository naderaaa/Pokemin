using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Board board; 
    
    // Start is called before the first frame update
    void Start()
    {
        
        //board = GameObject.Find("Grid").GetComponent<Board>();
    
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void EndTurn()
    {
        foreach (GameObject tileObject in board.tiles)
        {
            Tile tile = tileObject.GetComponent<Tile>();
            if (tile.piece != null)
            {
                tile.piece.Steps = tile.piece.Speed;

            }
            //Debug.Log(":3");

        }
    }
}
