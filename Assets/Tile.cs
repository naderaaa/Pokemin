using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{

    public int posx;
    public int posy;
#nullable enable 
    public Piece? piece;
#nullable disable
    public Image displayImage;

    public void PosGeneration()
    {
        Vector3 pos = new((posx * 109) + 111, (posy * 109) + 100, gameObject.transform.position.z);
        gameObject.transform.position = pos;


    }
    public void SetPiece(Piece piece)
    {
        this.piece = piece;
        displayImage.enabled = true;
        displayImage.sprite = piece.PieceSprite;
    }

    //public void SetPieceToCircle()
    //{
    //    this.piece = null; 
    //    displayImage.enabled = false;
    //    displayImage.sprite = null;
    //}

    public void TileSelected()
    {
        if (piece == null) return;
        HighlightAdjacent();
    }
    
    public void HighlightAdjacent()
    {
        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {

                if (i + posx <= 8 && i + posx >= 0 && j + posy <= 8 && j + posy >= 0)
                {
                    GameObject adjTile = GameObject.Find("tile" + (i + posx) + "_" + (j + posy));
                    Tile tile = adjTile.GetComponent<Tile>();
                    if (tile.piece == null)
                    {
                        tile.SetPiece(piece);
                    }
                }
            }
        }
    }
}
