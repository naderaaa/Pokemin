using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{

    public int posx; // position in grid
    public int posy;
#nullable enable
    public Piece? piece; // null when tile is empty, otherwise holds a pokemon
#nullable disable
    public Image displayImage; // the image on display
    public bool highlighted = false;
    public Tile lastSelectedTile;

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
        if (highlighted)
        {


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
           
            SetPiece(lastSelectedTile.piece);
            lastSelectedTile.SetPiece(null);
            highlighted = false;

            // clear highlighted ones 
            

        }
        else if (piece == null)
        {
            highlighted = false;
            return;
        }
        else
        {
            HighlightAdjacent();

        }

        
        // if piece.steps > 0 {


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
