using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class MovedPlatformConroller : MonoBehaviour
{
    [SerializeField] GameObject[] MovedPlatforms;
    [SerializeField] GameObject[] MovedLeftBarriers;
    [SerializeField] GameObject[] MovedRightBarriers;
    private void Start()
    {
        GameManager.Instance.MovedPlatformConroller = this;
    }

    public void PlatformMove()
    {
        MovedPlatformMove();
        MovedLeftBarrier();
        MovedRightBarrier();
    }

    private void MovedPlatformMove()
    {
        MovedPlatforms[GameManager.Instance.CurrentPlatform].transform.DOMoveY(-.22f, .5f);
    }

    private void MovedLeftBarrier()
    {
        MovedLeftBarriers[GameManager.Instance.CurrentPlatform].transform.DORotate(new Vector3(0, 0, 90), 1.5f);
    }

    private void MovedRightBarrier()
    {
        MovedRightBarriers[GameManager.Instance.CurrentPlatform].transform.DORotate(new Vector3(0, 0, -90), 1.5f);
    }
}
