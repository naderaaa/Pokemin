using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InfoUI : MonoBehaviour
{
    public static InfoUI Instance; // uses a singleton
    public Image displayImage; // the actual infoui image

    // piece specific elements
    public TextMeshProUGUI pieceName; // text display for the name
    public Image pieceDisplay; // piece's sprite
    public TextMeshProUGUI pieceHP;
    public TextMeshProUGUI pieceATK;
    public TextMeshProUGUI pieceATKAdjustments; // eventually will display a pokemons atk adjustments (like +2 or -2)
    public TextMeshProUGUI pieceSPE;
    public TextMeshProUGUI pieceSPEAdjustments; // same deal here
    public TextMeshProUGUI pieceRNG;
    public TextMeshProUGUI pieceRNGAdjustments; // same deal here
    public AbilityButton[] buttons = new AbilityButton[2]; // the ability buttons

    // handling the animation
    private readonly float OpenXPos = 345f; // the xposition when fully opened
    private readonly float ClosedXPos = -170f; // the xposition when fully closed
    private readonly float duration = .175f; // how long it takes to open and close

    public IPurchasable toDisplay; // whatever's on display
    public bool Opened = false; // whether or not the ui is opened

    private void Start()
    {
        Instance = this; // sets the singleton
    }

    public void OpenUI(IPurchasable purchasable)
    {
        toDisplay = purchasable;
        pieceName.text = purchasable.GetType().ToString(); // setting the infoui's name text
        pieceDisplay.sprite = purchasable.Sprite; // setting the infoui's sprite display
        switch (purchasable)
        {
            case Piece piece: // in the case of a piece
                pieceHP.text = piece.HP + "/" + piece.MaxHP;
                pieceATK.text = piece.Atk.ToString();
                pieceSPE.text = piece.Steps + "/" + piece.Speed;
                pieceRNG.text = piece.Range.ToString();
                // eventually put the adjustments over here

                for (int i = 0; i < 2; i++) // for both buttons
                {
                    if (piece.Abilities[i] != null) // if the piece has an ability
                    {
                        buttons[i].SetButton(piece.Abilities[i]); // display it
                    } 
                    else // if not
                    {
                        buttons[i].HideButton(); // hide the button
                    }
                }
                break;
            case Item item:
                item.ToString(); // message was annoying
                // eventually get this to work
                break;
        }
        StartCoroutine(MoveImageToRight()); // handles movement
        Opened = true; // flag wave

    }
    public void CloseUI()
    {
        StartCoroutine(MoveImageToLeft()); // hides the ui
        Opened = false; // flag wave

    }

    public IEnumerator MoveImageToRight()
    {
        Vector3 initialPos = displayImage.transform.localPosition; 
        Vector3 targetPos = new(OpenXPos, initialPos.y, initialPos.z);
        float elapsedTime = 0f; 
        while (elapsedTime < duration)
        {
            float t = elapsedTime / duration;
            t = Mathf.SmoothStep(0f, 1f, t);
            displayImage.transform.localPosition = Vector3.Lerp(initialPos, targetPos, t);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        displayImage.transform.localPosition = targetPos;
    }

    public IEnumerator MoveImageToLeft()
    {
        Vector3 initialPos = displayImage.transform.localPosition;
        Vector3 targetPos = new(ClosedXPos, initialPos.y, initialPos.z);
        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            float t = elapsedTime / duration;
            t = Mathf.SmoothStep(0f, 1f, t);
            displayImage.transform.localPosition = Vector3.Lerp(initialPos, targetPos, t);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        displayImage.transform.localPosition = targetPos;

    }

    public void Reload()
    {
        CloseUI();
        OpenUI(toDisplay);
    }
}
