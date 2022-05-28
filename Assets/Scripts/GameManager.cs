using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerController PlayerController;
    public static GameManager Instance { get; private set; }
    [HideInInspector] public GameStatus GameStatusCache;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            GameStatusCache = GameStatus.NONE;
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