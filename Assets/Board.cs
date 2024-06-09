using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject[,] tiles;
    public GameObject tilePrefab;

    void Start()
    {
        for (int x = 0; x < 9; x++)
        {
            for (int y = 0; y < 9; y++)
            {
                GameObject tileObj = GameObject.Instantiate(tilePrefab, gameObject.transform);
                tileObj.name = "tile" + x + "_" + y;
                Tile tile = tileObj.GetComponent<Tile>();

                if (x == 2 && y == 5)
                {
                    //tile.pokemon = new Swablu();
                    tile.SetPiece(new Swablu());

                }


                tile.posx = x;
                tile.posy = y;
                tile.PosGeneration();


            }
        }
    }


}
