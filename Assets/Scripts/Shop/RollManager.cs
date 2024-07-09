using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RollManager : MonoBehaviour
{
    private static List<IPurchasable> potentialShopElements => new()
    {
        // pokemons
        new Azurill(),
        new Bulbasaur(),
        new Chiyu(),
        new Corphish(),
        new Corsola(),
        new Corsola_G(),
        new Cottonee(),
        new Deino(),
        new Dratini(),
        new Dreepy(),
        new Dwebble(),
        new Flygon(),
        new Glimmet(),
        new Hatenna(),
        new IronBundle(),
        new IronValiant(),
        new Ivysaur(),
        new Jirachi(),
        new Joltik(),
        new Litwick(),
        new Magearna(),
        new Mantyke(),
        new Mareanie(),
        new Marill(),
        new Mawile(),
        new Porygon(),
        new Regieleki(),
        new Shaymin(),
        new Shroomish(),
        new SlitherWing(),
        new Sneasel(),
        new Starly(),
        new Staryu(),
        new Swablu(),
        new Tinkatink(),
        new Trapinch(),
        new Victini(),
        new Wochien(),

        // items
        // new Leftovers()
    };
    public static List<IPurchasable> PotentialShopElements { get => new(potentialShopElements); }

    public static IPurchasable RollAnItem(int shopTier)
    {
        //int shopTier = math.min((GameManager.turn / 2) + 1, 6);
        List<IPurchasable> availablePool = RollManager.PotentialShopElements.Where(potentialItem => potentialItem.Tier <= shopTier).ToList(); // creates a pool of rollable items
        System.Random random = new(); // makes an rng
        return availablePool[random.Next(0, availablePool.Count)]; // gets a random shopitem
    }

}
