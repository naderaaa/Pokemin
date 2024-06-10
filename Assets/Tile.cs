using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{

    public int posx; // x position in grid
    public int posy; // y position in grid
#nullable enable
    public Piece? piece; // null when tile is empty, otherwise holds a pokemon
#nullable disable
    public Image displayImage; // the image on display
    public bool highlighted = false; // a highlighted tile is empty and a pokemon is moved to that tile when clicked
    public static bool selected = false; // any piece is currently selected
    public Tile lastSelectedTile; // handles moving

    public void PosGeneration() // generates the position relative to the scene using a formula
    {
        Vector3 pos = new((posx * 109) + 111, (posy * 109) + 100, gameObject.transform.position.z);
        gameObject.transform.position = pos; // using a vector
    }
    public void SetPiece(Piece piece) // sets piece and affects the sprite
    {
        if (piece == null)
        {
            displayImage.enabled = false;
            displayImage.sprite = null;
            this.piece = null;
        }
        else
        {
            this.piece = piece;
            displayImage.enabled = true;
            displayImage.sprite = piece.PieceSprite;
        }

    }

    //public void TileSelected() // the onclick method for a tile
    //{
    //
    //    // four cases 
    //    // case 1: normal attacking
    //    // clicking attack lets you target your attack
    //    // case 2: using an ability
    //    // clicking an ability lets you target your ability, then select where to use it
    //    // case 3: moving
    //    // clicking on a highlighted tile moves the piece
    //    // case 4: just clicking
    //    // clicking a piece highlights surrounding empty tiles
    //
    //
    //    if (highlighted)
    //    {
    //
    //
    //        for (int i = -1; i <= 1; i++)
    //        {
    //            for (int j = -1; j <= 1; j++)
    //            {
    //                if (i + lastSelectedTile.posx <= 8 && i + lastSelectedTile.posx >= 0 && j + lastSelectedTile.posy <= 8 && j + lastSelectedTile.posy >= 0 && !(i == 0 && j == 0))
    //                {
    //                    GameObject adjTile = GameObject.Find("tile" + (i + lastSelectedTile.posx) + "_" + (j + lastSelectedTile.posy)); // maybe change this? it works??
    //                    Tile tile = adjTile.GetComponent<Tile>();
    //                    tile.highlighted = false;
    //                    tile.displayImage.enabled = false;
    //                    tile.displayImage.sprite = null;
    //                }
    //        
    //                
    //            }
    //        }
    //       
    //        SetPiece(lastSelectedTile.piece);
    //        lastSelectedTile.SetPiece(null);
    //        highlighted = false;
    //        piece.Steps--;
    //
    //        // clear highlighted ones 
    //        
    //
    //    }
    //    else if (piece == null)
    //    {
    //        highlighted = false;
    //        return;
    //    }
    //    else
    //    {
    //        HighlightAdjacent();
    //
    //    }
    //
    //    
    //    // if piece.steps > 0 {
    //
    //
    //}

    public void TileSelected() // the onclick method for a tile
    {

        // four cases 
        // case 1: normal attacking
        // clicking attack lets you target your attack
        // case 2: using an ability
        // clicking an ability lets you target your ability, then select where to use it
        // case 3: moving
        // clicking on a highlighted tile moves the piece
        // case 4: just clicking
        // clicking a piece highlights surrounding empty tiles


        if (highlighted) // case 3: moving
        {
            // first clear all other highlighted spaces
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i + lastSelectedTile.posx <= 8 && i + lastSelectedTile.posx >= 0 && j + lastSelectedTile.posy <= 8 && j + lastSelectedTile.posy >= 0 && !(i == 0 && j == 0))
                    {
                        GameObject adjTile = GameObject.Find("tile" + (i + lastSelectedTile.posx) + "_" + (j + lastSelectedTile.posy)); // maybe change this? it works??
                        Tile tile = adjTile.GetComponent<Tile>();
                        tile.highlighted = false;
                        tile.displayImage.enabled = false;
                        tile.displayImage.sprite = null;
                    }
                }
            }

            SetPiece(lastSelectedTile.piece); // move piece over
            lastSelectedTile.SetPiece(null); // delete old location
            highlighted = false; // unhighlight the tile
            selected = false;
            piece.Steps--; // decrements steps
        }
        else if (piece == null)
        {
            ClearHighlights();
            selected = false;

        }
        else if (selected)
        {
            ClearHighlights();
            selected = false;


        }
        else if (piece.Steps > 0)
        {
            HighlightAdjacent();
            selected = true;

        }


        // if piece.steps > 0 {


    }

    public void ClearHighlights()
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                GameObject adjTile = GameObject.Find("tile" + i + "_" + j); // maybe change this? it works??
                Tile tile = adjTile.GetComponent<Tile>();
                tile.highlighted = false;
                tile.SetPiece(tile.piece);
                
            }
        }
    }
    public void HighlightAdjacent() // sets the adjacent tiles to display a gray circle
    {
        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                //  this horrid if statement prevents going out of bounds and prevents overriding the center's image
                if (i + posx <= 8 && i + posx >= 0 && j + posy <= 8 && j + posy >= 0 && !(i == 0 && j == 0))
                {
                    GameObject adjTile = GameObject.Find("tile" + (i + posx) + "_" + (j + posy)); // maybe change this? it works??
                    Tile tile = adjTile.GetComponent<Tile>();
                    if (tile.piece == null)
                    {
                        tile.Highlight();
                        tile.lastSelectedTile = this;
                    }
                }
            }
        }
    }

    public void Highlight()
    {
        highlighted = true;
        displayImage.enabled = true;
        Sprite sprite = Resources.Load<Sprite>(FilePaths.MoveCircle);
        displayImage.sprite = sprite;
    }
}
