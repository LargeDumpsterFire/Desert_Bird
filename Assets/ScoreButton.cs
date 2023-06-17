using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{
    private Button _button2;
    private void Awake()
    {
        _button2 = GetComponent<Button>();
        _button2.onClick.AddListener(btnClick);
    }
    void btnClick()
    {
        Debug.Log("Highscore Button Clicked. Load highscore Scene");

        SceneManager.LoadScene("Score");

    }
}