using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoUI : MonoBehaviour
{
    // Start is called before the first frame update
    public static InfoUI Instance;
    public Image displayImage;
    private float OpenXPos = 340f;
    private float ClosedXPos = -170f;
    private float duration = .2f;
    public IPurchasable toDisplay;
    public bool Opened = false;

    private void Start()
    {
        Instance = this;
    }

    public void OpenOrCloseUI()
    {
        if (!Opened)
        {
            StartCoroutine(MoveImageToRight());
            Opened = true;
        } else
        {
            StartCoroutine(MoveImageToLeft());
            Opened = false;
        }

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
