using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject tilePrefab;
    public Tile[,] tiles = new Tile[9, 9];


    void Start() // On start, creats a 9x9 grid of Tiles, stored in tiles 2d array.
    {
        for (int x = 0; x < 9; x++)
        {
            for (int y = 0; y < 9; y++)
            {
                GameObject tileObj = Instantiate(tilePrefab, gameObject.transform);
                tileObj.name = "tile" + x + "_" + y; // the tiles follow a naming convention "tile#_#", with the #'s representing x and y respectively
                Tile tile = tileObj.GetComponent<Tile>();

                // more instantiation stuff
                tile.posx = x;
                tile.posy = y;
                tile.PosGeneration(); // sets the position in the scene
                tiles[x, y] = tile;
            }
        }

        // for the purpose of testing. remove when buying from the shop works!
        tiles[1, 1].SetPiece(new Dwebble() { Team = GameManager.teams.Item1 });
        tiles[2, 1].SetPiece(new Swablu() { Team = GameManager.teams.Item1 });
        tiles[3, 1].SetPiece(new Starly() { Team = GameManager.teams.Item1 });
        tiles[4, 1].SetPiece(new Trapinch() { Team = GameManager.teams.Item1 });
        tiles[5, 7].SetPiece(new Dreepy() { Team = GameManager.teams.Item2 });
        tiles[6, 7].SetPiece(new Cottonee() { Team = GameManager.teams.Item2 });
        tiles[7, 7].SetPiece(new Dratini() { Team = GameManager.teams.Item2 });
        tiles[8, 7].SetPiece(new SlitherWing() { Team = GameManager.teams.Item2 });
    }

    public void PokemonMoving()
    {

    }
    public void PokemonAttacking()
    {

    }

    public void SelectTile()
    {

    }

}
