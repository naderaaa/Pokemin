using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public partial class Shop : MonoBehaviour
{
    public static Shop ShopInstance { get; private set; }
    public ShopPanel? ItemToPurchase { get; set; }
    public static int shopTier = 1;
    public GameObject shopText;
    public ShopPanel[] ShopPanels = new ShopPanel[6];
    public GameObject[] ShopPanelTileIcons = new GameObject[6];


    //public static Dictionary<ShopElement, int> PotentialShopElements = new();
    private void Start()
    {
        ShopInstance = this; // sets the singleton
    }
    public void Reroll() // handles rerolling the shop
    {
        if (GameManager.whosTurn.Energy > 0) // if enough energy is available
        {
            GameManager.whosTurn.Energy--; // decrement energy
            Debug.Log(GameManager.whosTurn.Energy); // keep track of the energy
            int itemsToGenerate = 3 + (shopTier / 2); // the shop will increase in size over time

            for (int i = 0; i < 6; i++) // for each shoppanel in the shop
            {
                if (i < itemsToGenerate) 
                {
                    IPurchasable shopItem = RollManager.RollAnItem(shopTier); // get a shopitem
                    ShopPanels[i].shopItem = shopItem; // set that shopitem
                    ShopPanels[i].GetComponent<Image>().sprite = shopItem.Sprite; // set the sprite
                    ShopPanels[i].GetComponent<Image>().enabled = true; // enable the sprite

                    ShopPanelTileIcons[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Dice_Number_" + shopItem.Tier); // set the die in the corner
                    ShopPanelTileIcons[i].GetComponent<Image>().enabled = true; // enable the die sprite
                    ShopPanels[i].shopPanelTileIcon = ShopPanelTileIcons[i]; // store it in the array
                }
                else
                {
                    ShopPanels[i].GetComponent<Image>().sprite = Resources.Load<Sprite>(FilePaths.ClosedSign); // sets the sign for a closed stall
                    ShopPanels[i].GetComponent<Image>().enabled = true; // enables the closed stall sprite
                    ShopPanelTileIcons[i].GetComponent<Image>().enabled = false; // turn off the die sprite
                }
            }
        }
    }



}

public interface IPurchasable // an interface for every item rollable in the shop
{
    public int Tier { get; }
    public Sprite Sprite { get; }
}
