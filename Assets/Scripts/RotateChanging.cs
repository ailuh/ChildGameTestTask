using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RotateChanging : MonoBehaviour
{
    [SerializeField] GridLayoutGroup _gridGroup;
    [SerializeField] RectTransform _text;
    [SerializeField] RectTransform _largeImage;
    [SerializeField] RectTransform _contentWidth;
    [SerializeField] Canvas canvas;

    void Start()
    {
        StartCoroutine("CheckOrientation");
    }

    IEnumerator CheckOrientation()
    {
        while (true)
        {
            var height = Mathf.Min(Screen.currentResolution.height, Screen.currentResolution.width);
            ChangeUISizes(height);
            yield return null;
        }
    }

    void ChangeUISizes(float height)
    {
        Vector2 canvasScale = new Vector2(canvas.transform.localScale.x, canvas.transform.localScale.y);
        _largeImage.GetComponent<RectTransform>().sizeDelta = new Vector2(height * 0.8f / canvasScale.x, height * 0.8f / canvasScale.y);
        var scaledHeight = height / canvasScale.y;
        var textCoordinate = (-0.9f * scaledHeight) / 2;
        _text.GetComponent<RectTransform>().localPosition = new Vector3(0, textCoordinate, 0);
        int pad = (int)((height * 0.1f) / canvasScale.x);
        _gridGroup.cellSize = new Vector2(height * 0.5f / canvasScale.x, height * 0.5f / canvasScale.y);
        _gridGroup.padding = new RectOffset(pad, pad, pad, pad);
        _gridGroup.spacing = new Vector2(height * 0.1f / canvasScale.x, height * 0.1f / canvasScale.y);
    }
}
