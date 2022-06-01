using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] List<Level> allLevel;
    [SerializeField] GameObject p1SpawnPoint, p2SpawnPoint, p3SpawnPoint;

    [HideInInspector] public static List<int> Platform = new List<int>();
    //private int _currentLevel;

    private void Start()
    {
        p1SpawnPoint.GetComponent<MeshRenderer>().enabled = false;
        p2SpawnPoint.GetComponent<MeshRenderer>().enabled = false;
        p3SpawnPoint.GetComponent<MeshRenderer>().enabled = false;


        //_currentLevel = GameManager.Instance.CurrentLevel - 1;
        //Debug.Log(GameManager.Instance.curr);
        GameManager.Instance.BallCount = 0;
        GameManager.Instance.CurrentPlatform = 0;
        Platform.Clear();
        LevelCreator(GameManager.Instance.CurrentLevel % allLevel.Count);
    }

    public void LevelCreator(int thisLevel)
    {
        //Debug.Log(thisLevel);
        BallPlatformSpawner(thisLevel);
        Platform.Add(allLevel[thisLevel].Platform1);
        Platform.Add(allLevel[thisLevel].Platform2);
        Platform.Add(allLevel[thisLevel].Platform3);
    }

    public void BallPlatformSpawner(int level)
    {
        GameObject.Instantiate(allLevel[level].PlatformPrefab1, p1SpawnPoint.transform);
        GameObject.Instantiate(allLevel[level].PlatformPrefab2, p2SpawnPoint.transform);
        GameObject.Instantiate(allLevel[level].PlatformPrefab3, p3SpawnPoint.transform);
    }
    #region MyRegion
    //public void NextLevel()
    //{
    //    GameManager.Instance.CurrentLevel++;
    //    GameManager.Instance.CurrentPlatform = 0;
    //    GameManager.Instance.CurrentPlatform++;
    //    levelCreator(GameManager.Instance.CurrentLevel);
    //}


    //public string CurrentPlatformWriter(int currentPlatform)
    //{
    //    return Platform[currentPlatform].ToString();
    //} 
    #endregion
}
