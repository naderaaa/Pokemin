using UnityEngine;


public class ShopPanel : MonoBehaviour
{
    public IPurchasable shopItem;

    public void OnClick()
    {
        Shop.ShopInstance.shopText.SetActive(true); // display shop text
        
    }
}


