using UnityEngine;
using UnityEngine.UI;

public class MainScreenController : MonoBehaviour
{
    [SerializeField] GameObject _viewPrefab; 
    void Start()
    {
        var height = Screen.currentResolution.height;
        var gridGroup = GetComponent<GridLayoutGroup>();
        int pad = (int)(height * 0.1f);

        gridGroup.cellSize = new Vector2(height * 0.5f, height * 0.5f);
        gridGroup.padding = new RectOffset(pad, pad, pad, pad);
        gridGroup.spacing = new Vector2(height * 0.1f, height * 0.1f);

        UnityEngine.Object[] files = Resources.LoadAll("Images/", typeof(Sprite));
        foreach (var file in files)
        {
            var element = Instantiate(_viewPrefab);
            element.name = file.name;
            var sprite = (Sprite)file;
            var image = element.GetComponentInChildren<Image>();
            image.sprite = sprite;
            element.transform.SetParent(this.transform);
            element.transform.localScale = new Vector3(1, 1, 1);
            element.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        }
      
    }

}
