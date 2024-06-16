using Unity.Mathematics;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject[] ShopItems = new GameObject[6];
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
                ShopItems[i].GetComponent<Renderer>(); // no idea
            }
        }
    }

    public Piece GetShopPiece()
    {
        return null;
    }
}
