using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemTouched : MonoBehaviour, IPointerClickHandler
{
    GameObject _imageLargeView;
    GameObject _mainScreen;
    ImageViewer _imageViewer;
    Sprite _image;
    private void Start()
    {
        _imageLargeView = GameObject.Find("Canvas/ImageSelected").gameObject;
        _mainScreen = GameObject.Find("Canvas/ImageList").gameObject;
        _imageViewer = _imageLargeView.GetComponent<ImageViewer>();
        _image = GetComponent<Image>().sprite;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        _mainScreen.gameObject.SetActive(false);
        var elementData = new ElementData(_image, gameObject.name);
        _imageViewer?.OnImageSelected(elementData);
    }
}
