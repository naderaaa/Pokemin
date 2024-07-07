using UnityEngine;


public class ShopPanel : MonoBehaviour
{
    public IPurchasable shopItem;
    public static bool buying = false;
    public void OnClick()
    {
        if (!buying)
        {
            buying = true;
            Shop.ShopInstance.shopText.SetActive(true); // display shop text
            Shop.ShopInstance.Purchasing = shopItem;
        } else
        {
            buying = false;
            Shop.ShopInstance.shopText.SetActive(false); // display shop text
            Shop.ShopInstance.Purchasing = null;

        }


    }
}


