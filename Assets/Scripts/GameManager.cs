using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public PlayerController PlayerController;
    
    public static GameManager Instance { get; private set; }
    [HideInInspector] public GameStatus GameStatusCache;
    [HideInInspector] public int BallCount, CurrentPlatform, CurrentLevel;

    public SaveManager SaveManager;
    public MovedPlatformConroller MovedPlatformConroller;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            BallCount = 0;
            CurrentPlatform = 0;
            GameStatusCache = GameStatus.NONE;
            DontDestroyOnLoad(gameObject);
        }
    }
}

public enum GameStatus
{
    NONE,
    PLAY,
    CONTROL,
    NEXTLEVEL,
    END
}