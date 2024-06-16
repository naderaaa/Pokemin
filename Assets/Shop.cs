using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public GameObject[] ShopPanels = new GameObject[6];
    
    //public static Dictionary<ShopElement, int> PotentialShopElements = new();
    // Start is called before the first frame update

    void Start()
    {
        
    }
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
                
            }
        }
    }

    public void RollAnItem()
    {
        int shopTier = math.min((GameManager.turn / 2) + 1, 6);
    }
    
}
public class ShopElement
{
    public int Tier;
}
