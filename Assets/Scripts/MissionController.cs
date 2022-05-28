using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionController : MonoBehaviour
{
    private int _platform1, _platform2, _platform3;
    [SerializeField] List<Level> allLevel;

    private void Start()
    {
        levelCreator(1);
    }

    public void levelCreator(int thisLevel)
    {
        _platform1 = allLevel[thisLevel- 1].Platform1;
        _platform2 = allLevel[thisLevel - 1].Platform2;
        _platform3 = allLevel[thisLevel - 1].Platform3;
    }

}
