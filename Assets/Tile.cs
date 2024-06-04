using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.U2D;
using UnityEngine;

public class Tile : MonoBehaviour
{
    
    public int posx;
    public int posy;
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
    public Pokemon? pokemon;
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
    


    // Start is called before the first frame update
    void Start()
    {
    }

    public void PosGeneration()
    {
        Vector3 pos = new((posx * 109) + 111, (posy * 109) + 100, gameObject.transform.position.z);
        gameObject.transform.position = pos;
        if (pokemon != null)
        {
            // Get the SpriteRenderer component from the child GameObject
            SpriteRenderer spriteRenderer = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();

            // Check if the SpriteRenderer component is not null
            if (spriteRenderer != null)
            {
                // Set the sprite
                spriteRenderer.sprite = pokemon.Sprite;

                // Change the opacity (alpha) of the sprite
                Color color = spriteRenderer.color;
                color.a = 1.0f; // Set opacity to 50%
                spriteRenderer.color = color;
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
