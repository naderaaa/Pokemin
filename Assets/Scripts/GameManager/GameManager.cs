using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    //public Shop shop;
    public Board board;
    public GameObject die;
    public GameObject energyDisplayText;
    public GameObject numberOfPokemonDisplayText;
    public static (Team, Team) teams = (new Team("Red"), new Team("Blue"));
    public static Team whosTurn = teams.Item1;
    public static int turn = 1;
    public readonly static int MAX_POKEMON = 6;

    private void Start()
    {
        die = GameObject.Find("Reroll");
        whosTurn.Energy = whosTurn.MaxEnergy;
        StartShop();

        /* someone please fix this */
        energyDisplayText.GetComponent<TextMeshProUGUI>().text = "5"; // i could not tell you why this is necessary but it breaks if i remove it
        Team.EnergyUpdated += (Sender, Energy) => { energyDisplayText.GetComponent<TextMeshProUGUI>().text = Energy.ToString(); };
        /* please */

        Team.PokemonCountUpdated += (Sender, PokemonCount) => { numberOfPokemonDisplayText.GetComponent<TextMeshProUGUI>().text = PokemonCount.ToString(); };

        Instance = this;
    }
    public void StartShop()
    {
        try
        {
            Shop.ShopInstance.Reroll();
        }
        catch (NullReferenceException)
        {
            Debug.Log("e");
        }
    }

    public void EndTurn()
    {
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
        Team.PokemonCountUpdated.Invoke(this, whosTurn.NumPokemon);

        // handling shopTier upgrades

        if (Shop.shopTier < (int)Math.Min(((double)turn / 2) + .5, 6))
        {
            Shop.shopTier = (int)Math.Min(((double)turn / 2) + .5, 6);
            die.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Dice_Number_" + Shop.shopTier);
        }

        ShopPanel.buying = false;
        Shop.ShopInstance.ItemToPurchase = null;
        Shop.ShopInstance.shopText.SetActive(false);

        Instance.board.ClearHighlightsAndTargets();

    }
}
