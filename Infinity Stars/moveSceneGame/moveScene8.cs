using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveScene8 : MonoBehaviour
{
    void Awake()
    {
        Screen.SetResolution(1920, 1080, true); //해상도 조정
    }

    public void GoToGame()
    {
        SceneManager.LoadScene("Flight8");
    }
}
