using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject tilePrefab;

    void Start() // On start, creats a 9x9 grid of Tiles, stored in tiles 2d array.
    {
        for (int x = 0; x < 9; x++)
        {
            for (int y = 0; y < 9; y++)
            {
                GameObject tileObj = GameObject.Instantiate(tilePrefab, gameObject.transform);
                tileObj.name = "tile" + x + "_" + y; // the tiles follow a naming convention "tile#_#", with the #'s representing x and y respectively
                Tile tile = tileObj.GetComponent<Tile>();


                // for the purpose of testing. remove when buying from the shop works!
                if (x == 1 && y == 1)
                {
                    tile.SetPiece(new Dwebble() { Team = GameManager.teams.Item1 });
                }
                else if (x == 2 && y == 1)
                {
                    tile.SetPiece(new Swablu() { Team = GameManager.teams.Item1 });
                }
                else if (x == 6 && y == 7)
                {
                    tile.SetPiece(new Cottonee() { Team = GameManager.teams.Item2 });
                }
                else if (x == 8 && y == 7)
                {
                    tile.SetPiece(new Mawile() { Team = GameManager.teams.Item2 });
                }

                // more instantiation stuff
                tile.posx = x;
                tile.posy = y;
                tile.PosGeneration(); // sets the position in the scene
                GameManager.tiles[x, y] = tileObj;


            }
        }
    }

}
