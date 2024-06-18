using System;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Board board;
    public Shop shop;
    public static (Team, Team) teams = (new Team("Red"), new Team("Blue"));
    public static Team whosTurn = teams.Item1;
    public static int turn = 1;
    public static Tile[,] tiles = new Tile[9, 9];

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

        // handling shopTier upgrades
        if (shop.shopTier < Math.Min((turn / 2) + 1, 6))
        {
            shop.shopTier = Math.Min((turn / 2) + 1, 6);
            shop.die.GetComponent<Image>().sprite = Resources.Load<Sprite>("Dice_Number_" + shop.shopTier);
        }
        
        Tile.ClearHighlightsAndTargets();
    }
}
