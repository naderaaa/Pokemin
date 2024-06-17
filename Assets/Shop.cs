using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public GameObject[] ShopPanels = new GameObject[6];
    
    //public static Dictionary<ShopElement, int> PotentialShopElements = new();
    // Start is called before the first frame update

    public static void TurnStart()
    {

    }

    public void Reroll()
    {
        int shopTier = math.min((GameManager.turn / 2) + 1, 6);
        int itemsToGenerate = 3 + (shopTier / 2);

        for (int i = 0; i < 6; i++)
        {
            if (i < itemsToGenerate)
            {
                IPurchasable shopItem = RollAnItem(shopTier);
                ShopPanels[i].GetComponent<Image>().sprite = shopItem.Sprite;
                ShopPanels[i].GetComponent<Image>().enabled = true;
            }
        }
    }

    public IPurchasable RollAnItem(int shopTier)
    {
        //int shopTier = math.min((GameManager.turn / 2) + 1, 6);
        List<IPurchasable> availablePool = RollManager.PotentialShopElements.Where(potentialItem => potentialItem.Tier <= shopTier).ToList();
        System.Random random = new(availablePool.Count);
        return availablePool[random.Next()];
    }
    
}
public interface IPurchasable
{
    public int Tier { get; }
    public Sprite Sprite { get; }
}
