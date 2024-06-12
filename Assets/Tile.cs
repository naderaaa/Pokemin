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
    public Image teamSymbol;
    public Image targetOverlay;
    public bool highlighted = false; // a highlighted tile is empty and a pokemon is moved to that tile when clicked
    public bool targeted = false;
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
        else // case for deleting contents
        {
            this.piece = piece;
            displayImage.enabled = true;
            displayImage.sprite = piece.PieceSprite;
        }

    }

    public void TileSelected() // the onclick method for a tile
    {

        // case 1: selecting a tile
        // case 2: deselecting a tile by clicking on a non highlighted tile
        // case 3: deselecting a tile by clicking on the selected tile
        // case 4: moving my clicking a highlighted tile
        // case 5: attacking normally
        // case 6: targeting an ability

        if (highlighted) // case 4
        {
            // first clear all other highlighted spaces
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i + lastSelectedTile.posx <= 8 && i + lastSelectedTile.posx >= 0 && j + lastSelectedTile.posy <= 8 && j + lastSelectedTile.posy >= 0 && !(i == 0 && j == 0))
                    {
                        GameObject adjTile = GameManager.tiles[i + lastSelectedTile.posx, j + lastSelectedTile.posy];
                        Tile tile = adjTile.GetComponent<Tile>();
                        tile.highlighted = false;
                        tile.displayImage.enabled = false;
                        tile.displayImage.sprite = null;
                        tile.SetPiece(tile.piece);
                    }
                }
            }
            SetPiece(lastSelectedTile.piece); // move piece over
            lastSelectedTile.SetPiece(null); // delete old location
            highlighted = false; // unhighlight the tile
            selected = false;
            piece.Steps--; // decrements steps

        }
        else if (piece == null) // case 2
        {
            ClearHighlights();
            selected = false;

        }
        else if (selected) // case 3 (selected)
        {
            ClearHighlights();
            selected = false;

        }
        else if (piece.Steps > 0 && piece.Team.Name.Equals(GameManager.whosTurn.Name)) // case 1
        {
            HighlightAdjacent();
            TargetInRange();
            selected = true;
        }

    }

    public void ClearHighlights()
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                GameObject adjTile = GameManager.tiles[i, j];
                Tile tile = adjTile.GetComponent<Tile>();
                tile.highlighted = false;
                tile.targeted = false;
                tile.SetPiece(tile.piece);
                tile.targetOverlay.enabled = false;
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
                    GameObject adjTile = GameManager.tiles[i + posx, j + posy];
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


    public void TargetInRange()
    {
        if (piece != null)
        {
            for (int i = -piece.Range; i < piece.Range; i++)
            {
                for (int j = -piece.Range; j < piece.Range; j++)
                {
                    if (i + posx <= 8 && i + posx >= 0 && j + posy <= 8 && j + posy >= 0 && !(i == 0 && j == 0))
                    {
                        GameObject tileInRange = GameManager.tiles[i + posx, j + posy];
                        Tile tile = tileInRange.GetComponent<Tile>();
                        if (tile.piece != null)
                        {
                            tile.Target();
                            tile.lastSelectedTile = this;
                        }
                    }
                }
            }
        }
    }

    public void Target()
    {
        targeted = true;
        targetOverlay.enabled = true;
    }
}
