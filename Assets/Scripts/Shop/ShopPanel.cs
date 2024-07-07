using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopPanel : MonoBehaviour
{
    public IPurchasable? shopItem;
    public GameObject shopPanelTileIcon;
    public static bool buying = false;
    public void OnClick()
    {
        if (!buying)
        {
            if (GameManager.whosTurn.Energy >= 2 && GameManager.whosTurn.NumPokemon < 6)
            {
                buying = true;
                Shop.ShopInstance.shopText.SetActive(true); // display shop text
                if (GameManager.whosTurn == GameManager.teams.Item1)
                {
                    Shop.ShopInstance.shopText.GetComponent<TextMeshProUGUI>().text = "Purchase a Pokemon by placing it in a space in one of the bottom two rows!";
                } 
                else
                {
                    Shop.ShopInstance.shopText.GetComponent<TextMeshProUGUI>().text = "Purchase a Pokemon by placing it in a space in one of the top two rows!";
                }
                Shop.ShopInstance.ItemToPurchase = this;
            }
        } 
        else
        {
            buying = false;
            Shop.ShopInstance.shopText.SetActive(false); // turn off shop text
            Shop.ShopInstance.ItemToPurchase = null;

        }
    }

    public void AfterPurchase()
    {
        if (GameManager.whosTurn.Energy >= 2 && GameManager.whosTurn.NumPokemon < 6) // if the purchase went through
        {
            GameManager.whosTurn.Energy -= 2;
            GameManager.whosTurn.NumPokemon++;
            shopItem = null;
            GetComponent<Image>().enabled = false;
            shopPanelTileIcon.GetComponent<Image>().enabled = false;
        }
        
        buying = false;
        Shop.ShopInstance.shopText.SetActive(false); // turn off shop text

    }
}


