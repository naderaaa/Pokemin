using Unity.Mathematics;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject ShopItemPrefab;
    // Start is called before the first frame update
    void Start()
    {

        // load closed shop asset
        return;
    }

    public static void TurnStart()
    {

    }

    public static void Reroll()
    {
        int shopTier = math.min((GameManager.turn / 2) + 1, 6);
        int itemsToGenerate = 3 + (shopTier / 2);
    }
}
