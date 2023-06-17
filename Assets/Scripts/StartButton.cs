using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    private Button _button;
    private void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(btnClick);
    }
    void btnClick()
    {
        Debug.Log("Button Clicked. Load Game Scene");
       
        SceneManager.LoadScene("Game");
    
    }
}