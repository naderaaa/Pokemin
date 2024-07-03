using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public static Shop ShopInstance { get; private set; }
    public static int shopTier = 1;
    public GameObject[] ShopPanels = new GameObject[6];
    public GameObject[] ShopPanelTileIcons = new GameObject[6];


    //public static Dictionary<ShopElement, int> PotentialShopElements = new();
    private void Start()
    {
        ShopInstance = this;
       
    }
    public void Reroll()
    {
        if (GameManager.whosTurn.Energy > 0)
        {
            GameManager.whosTurn.Energy--;
            Debug.Log(GameManager.whosTurn.Energy);
            int itemsToGenerate = 3 + (shopTier / 2);

            for (int i = 0; i < 6; i++)
            {
                if (i < itemsToGenerate)
                {
                    IPurchasable shopItem = RollAnItem(shopTier);
                    ShopPanels[i].GetComponent<Image>().sprite = shopItem.Sprite;
                    ShopPanels[i].GetComponent<Image>().enabled = true;

                    ShopPanelTileIcons[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Dice_Number_" + shopItem.Tier);
                    ShopPanelTileIcons[i].GetComponent<Image>().enabled = true;
                }
                else
                {
                    ShopPanels[i].GetComponent<Image>().sprite = Resources.Load<Sprite>(FilePaths.ClosedSign);
                    ShopPanels[i].GetComponent<Image>().enabled = true;
                    ShopPanelTileIcons[i].GetComponent<Image>().enabled = false;
                }
            }
        }
    }

    public IPurchasable RollAnItem(int shopTier)
    {
        //int shopTier = math.min((GameManager.turn / 2) + 1, 6);
        List<IPurchasable> availablePool = RollManager.PotentialShopElements.Where(potentialItem => potentialItem.Tier <= shopTier).ToList();
        System.Random random = new();
        return availablePool[random.Next(0, availablePool.Count - 1)];
    }

}

public class ShopPanel
{
    public IPurchasable shopItem;
}

public interface IPurchasable
{
    public int Tier { get; }
    public Sprite Sprite { get; }
}
