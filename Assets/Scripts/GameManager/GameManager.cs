using System;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public Board board;
    public GameObject die;
    public static (Team, Team) teams = (new Team("Red"), new Team("Blue"));
    public static Team whosTurn = teams.Item1;
    public static int turn = 1;

    private void Start()
    {
        die = GameObject.Find("Reroll");
        whosTurn.Energy = whosTurn.MaxEnergy;
        Instance = this;
    }
    public void StartShop()
    {

    }

    public void EndTurn()
    {
        //if (shop is null)
        //{
        //    Debug.Log("hi");
        //}
        // at the end of the turn, each pokemon can start moving
        foreach (Tile tile in board.tiles)
        {
            if (tile.pieceOnTile is not null)
            {
                tile.pieceOnTile.Steps = tile.pieceOnTile.Speed;
            }
        }
        // switching whos turn it is
        if (whosTurn.Name.Equals(teams.Item1.Name))
        {
            whosTurn = teams.Item2;
        }
        else
        {
            whosTurn = teams.Item1;
            turn++;
        }

        whosTurn.Energy = whosTurn.MaxEnergy;
        Debug.Log(whosTurn.Energy);

        // handling shopTier upgrades

        if (Shop.shopTier < (int)Math.Min(((double)turn / 2) + .5, 6))
        {
            Shop.shopTier = (int)Math.Min(((double)turn / 2) + .5, 6);
            die.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Dice_Number_" + Shop.shopTier);
        }

        GameManager.Instance.board.ClearHighlightsAndTargets();

    }
}
