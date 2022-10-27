using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ImageViewer : MonoBehaviour
{
    [SerializeField] Image _image;
    [SerializeField] TextMeshProUGUI _text;

    private void Start()
    {
        var height = Screen.currentResolution.height;
        _image.GetComponent<RectTransform>().sizeDelta = new Vector2(height * 0.8f, height * 0.8f);
        _text.GetComponent<RectTransform>().localPosition = new Vector3(0, -height * 0.4f - (height - height * 0.8f) * 0.25f, 0);
    }
    public void OnImageSelected(ElementData elementData)
    {
        _image.sprite = elementData.Image;
        _text.text = elementData.Name;
    }
}
