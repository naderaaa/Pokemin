using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InfoUI : MonoBehaviour
{
    // Start is called before the first frame update
    public static InfoUI Instance;
    public Image displayImage;
    public TextMeshProUGUI pieceName;
    public Image pieceDisplay;
    public TextMeshProUGUI pieceHP;
    public TextMeshProUGUI pieceATK;
    public TextMeshProUGUI pieceATKAdjustments;
    public TextMeshProUGUI pieceSPE;
    public TextMeshProUGUI pieceSPEAdjustments;
    public TextMeshProUGUI pieceRNG;
    public TextMeshProUGUI pieceRNGAdjustments;
    public AbilityButton[] buttons = new AbilityButton[2];

    private readonly float OpenXPos = 345f;
    private readonly float ClosedXPos = -170f;
    private readonly float duration = .175f;
    public IPurchasable toDisplay;
    public bool Opened = false;

    private void Start()
    {
        Instance = this;
    }

    public void OpenUI(IPurchasable purchasable)
    {
        pieceName.text = purchasable.GetType().ToString();
        pieceDisplay.sprite = purchasable.Sprite;
        switch (purchasable)
        {
            case Piece piece:
                pieceHP.text = piece.HP + "/" + piece.MaxHP;
                pieceATK.text = piece.Atk.ToString();
                pieceSPE.text = piece.Steps + "/" + piece.Speed;
                pieceRNG.text = piece.Range.ToString();
                for (int i = 0; i < 2; i++)
                {
                    if (buttons[i] != null)
                    {
                        buttons[i].SetButton(piece.Abilities[i]);
                    }
                }
                break;
            case Item item:

                break;
        }
        StartCoroutine(MoveImageToRight());
        Opened = true;

    }
    public void CloseUI()
    {
        StartCoroutine(MoveImageToLeft());
        Opened = false;

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
}
