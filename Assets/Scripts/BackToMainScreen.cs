using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackToMainScreen : MonoBehaviour
{
    [SerializeField] GameObject _iamgeMainScreen;

    void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(ReturnToMainScreen);
    }

    void ReturnToMainScreen()
    {
        _iamgeMainScreen.SetActive(true);
    }

}
