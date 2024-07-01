using System;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Board board;
    public GameObject die;
    public static (Team, Team) teams = (new Team("Red"), new Team("Blue"));
    public static Team whosTurn = teams.Item1;
    public static int turn = 1;
    public static Tile[,] tiles = new Tile[9, 9];

    private void Start()
    {
        die = GameObject.Find("Reroll");
        whosTurn.Energy = whosTurn.MaxEnergy;
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
        foreach (Tile tile in tiles)
        {
            if (tile.piece is not null)
            {
                tile.piece.Steps = tile.piece.Speed;
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

        Tile.ClearHighlightsAndTargets();

    }
}
