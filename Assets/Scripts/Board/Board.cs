using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject tilePrefab;
    public Tile[,] tiles = new Tile[9, 9];
    public Tile selected; // any piece is currently selected
    public List<Tile> targetable; // a targetable tile contains a piece and is attacked when that tile is clicked
    public List<Tile> movable; // a movable tile is empty and a pokemon is moved to that tile when clicked
    public Tile showingInfo; // the tile with info currently being displayed about it


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
    }

    public void SelectTile(Tile tile)
    {
        // case 1: selecting a tile with
        // case 2: selecting a tile with
        // case 3: deselecting a tile by
        // case 4: deselecting a tile by
        // case 5: moving by clicking a 
        // case 6: attacking normally
        // case 7: targeting an ability

        if (movable.Contains(tile)) // moving by clicking a highlighted tile
        {
            MoveToHighlightedSpace(tile);
        }
        else if (targetable.Contains(tile)) // attacking by clicking a targetable tile
        {
            AttackingATargetedSpace(tile);
        }
        else if (tile.pieceOnTile == null) // deselecting a tile by clicking on a non highlighted tile 
        {
            ClearHighlightsAndTargets();
        }
        else if (selected)// deselecting a tile by clicking on the selected tile
        {
            ClearHighlightsAndTargets();
        }
        else if (tile.pieceOnTile.Steps > 0 && tile.pieceOnTile.Team.Name.Equals(GameManager.whosTurn.Name)) // selecting a tile with steps
        {
            if (GameManager.whosTurn.Energy > 0 || tile.pieceOnTile.moved)
            {
                HighlightAdjacent(tile);
                TargetInRange(tile);
                selected = tile;

            }
        }
        else if (tile.pieceOnTile.Team.Name.Equals(GameManager.whosTurn.Name) && !tile.attacked)
        {
            if (GameManager.whosTurn.Energy > 0)
            {
                TargetInRange(tile);
                selected = tile;
            }
        }

        if (tile.pieceOnTile != null && tile != showingInfo)
        {
            showingInfo = tile;
            InfoUI.Instance.OpenUI(tile.pieceOnTile);
        }
        else if (tile.pieceOnTile == null || selected == null || tile.pieceOnTile.Steps == 0)
        {
            showingInfo = null;
            InfoUI.Instance.CloseUI();
        }
    }

    public void MoveToHighlightedSpace(Tile tile) // ran when a highlighted tile is clicked on
    {
        tile.SetPiece(selected.pieceOnTile); // piece is copied over
        selected.SetPiece(null); // piece is removed from original location 
        ClearHighlightsAndTargets(); // all highlights/targets are removed
        movable.Remove(tile); // that tile is now is empty
        if (!tile.pieceOnTile.moved) // energy is only decremented once a pokemon moves the first time a turn
        {
            GameManager.whosTurn.Energy--;
            tile.pieceOnTile.moved = true;
        }
        tile.pieceOnTile.Steps--; // steps is decremented
    }

    public void AttackingATargetedSpace(Tile tile) // ran when a targeted tile is attacked
    {
        selected.pieceOnTile.Steps = 0; // piece cant move after attacking
        selected.attacked = true; // stops piece from attacking twice
        selected.pieceOnTile.Attack(tile.pieceOnTile); // handles the attack damage calculation
        ClearHighlightsAndTargets(); // all highlights/targets are removed
        if (tile.pieceOnTile.HP <= 0) // handles death
        {
            tile.pieceOnTile.Team.NumPokemon--; // num pokemon is decremented
            tile.pieceOnTile.Team.pokemon.Remove(tile.pieceOnTile); 
            tile.SetPiece(null); // piece is removed from board L bozo

        }
        GameManager.whosTurn.Energy--; // energy is decremented after attacking
    }

    public void ClearHighlightsAndTargets() // removes the gray circle indicating where you can move and red circle for attacking
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Tile tile = tiles[i, j]; // gets the tile
                movable.Remove(tile); // no tiles can be clicked and moved to
                targetable.Remove(tile); // no tiles can be attacked
                tile.SetPiece(tile.pieceOnTile); // im gonna be honest im not sure what this actually does but im scared to touch it
                tile.targetOverlay.enabled = false; // removes the target overlay
                selected = null; // no currently selected piece
            }
        }
    }

    public void HighlightAdjacent(Tile center) // sets the adjacent tiles to display a gray circle
    {
        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                //  this horrid if statement prevents going out of bounds and prevents overriding the center's image
                if (i + center.posx <= 8 && i + center.posx >= 0 && j + center.posy <= 8 && j + center.posy >= 0 && !(i == 0 && j == 0))
                {
                    Tile tile = tiles[i + center.posx, j + center.posy];
                    if (tile.pieceOnTile == null)
                    {
                        Highlight(tile);
                        selected = center;
                    }
                }
            }
        }
    }

    public void Highlight(Tile tile) // highlights spaces you can move to
    {
        movable.Add(tile);
        tile.displayImage.enabled = true;
        Sprite sprite = Resources.Load<Sprite>(FilePaths.MoveCircle);
        tile.displayImage.sprite = sprite;
        tile.displayImage.transform.localScale = new Vector3(1.5F, 1.5F, 1.5F);
    }

    public void TargetInRange(Tile center) // puts a target overlay above things you can attack
    {
        if (center.pieceOnTile != null)
        {
            for (int i = -center.pieceOnTile.Range; i <= center.pieceOnTile.Range; i++)
            {
                for (int j = -center.pieceOnTile.Range; j <= center.pieceOnTile.Range; j++)
                {
                    if (i + center.posx <= 8 && i + center.posx >= 0 && j + center.posy <= 8 && j + center.posy >= 0 && !(i == 0 && j == 0))
                    {
                        Tile tile = tiles[i + center.posx, j + center.posy];
                        if (tile.pieceOnTile != null)
                        {
                            Target(tile);
                            selected = tile;
                        }
                    }
                }
            }
        }
    }

    public void Target(Tile tile) // targets tile with the crosshair
    {
        targetable.Add(tile);
        tile.targetOverlay.enabled = true;
    }


}
