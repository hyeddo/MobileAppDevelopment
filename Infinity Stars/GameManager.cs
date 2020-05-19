using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{

    private static GameManager Instance = null;

    public static GameManager instance
    {
        get
        {
            if (Instance == null)
            {
                Instance = new GameManager();
            }
            return Instance;
        }
    }

    private GameManager()
    {

    }

    public int coins=100000;
    public int buy1 = 0;
    public int buy2 = 0;
    public int buy3 = 0;
    public int buy4 = 0;
    public int buy5 = 0;
    public int buy6 = 0;
    public int buy7 = 0;
    public int buy8 = 0;

    void awake()
    {
        Screen.SetResolution(1920, 1080, true); //해상도 조정
    }
}
