using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Level", menuName = "Level")]
public class Level : ScriptableObject
{
    [Range(0,200)]
    public int Platform1, Platform2, Platform3;

    [Header("Platform Prefabs")]
    public GameObject PlatformPrefab1;
    public GameObject PlatformPrefab2;
    public GameObject PlatformPrefab3;
}
