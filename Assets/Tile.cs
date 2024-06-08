using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    
    public int posx;
    public int posy;
    public Piece? piece;
    public Image displayImage;
    public Sprite[] sprites;

    public const int Azurill = 0;
    public const int Bulbasaur = 1;
    public const int Cottonee = 2;
    public const int Deino = 3;
    public const int Dratini = 4;
    public const int Dreepy = 5;
    public const int Dwebble = 6;
    public const int Hatenna = 7;
    public const int Joltik = 8;
    public const int Litwick = 9;
    public const int Mareanie = 10;
    public const int Mawile = 11;
    public const int Starly = 12;
    public const int Swablu = 13;
    public const int Tinkatink = 14;

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
}
