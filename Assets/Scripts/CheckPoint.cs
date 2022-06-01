using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CheckPoint : MonoBehaviour
{
    [Header ("Platform Force")]
    [SerializeField] float force;

    [Header("PlatformLevelUI")]
    [SerializeField]Image platformLevelUI;
    #region MyRegion
    //[SerializeField] Rigidbody ballRb;
    #endregion

    private void Start()
    {
        platformLevelUI.GetComponent<Image>().color = Color.white;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.GameStatusCache = GameStatus.CONTROL;
            StartCoroutine(Waiter());
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Ball") && GameManager.Instance.GameStatusCache == GameStatus.CONTROL)
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        }
        else if (other.CompareTag("Ball") && GameManager.Instance.GameStatusCache != GameStatus.CONTROL)
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * force);
        }
    }

    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(3f);
        PlatformLevelControl();
    }
 
    void PlatformLevelControl()
    {
        if (GameManager.Instance.BallCount >= LevelController.Platform[GameManager.Instance.CurrentPlatform] &&
            GameManager.Instance.CurrentPlatform + 1 < LevelController.Platform.Count)
        {
            GameManager.Instance.BallCount = 0;

            platformLevelUI.GetComponent<Image>().color = Color.green;
            #region MyRegion
            GameManager.Instance.MovedPlatformConroller.PlatformMove();
            #endregion
            GameManager.Instance.CurrentPlatform++;
            GameManager.Instance.GameStatusCache = GameStatus.PLAY;
        }
        else if (GameManager.Instance.BallCount >= LevelController.Platform[GameManager.Instance.CurrentPlatform] && 
            GameManager.Instance.CurrentPlatform + 1 >= LevelController.Platform.Count)
        {
            platformLevelUI.GetComponent<Image>().color = Color.green;
            //Debug.Log("Nextlevel");
            #region MyRegion
            //_movedPlatformConroller.PlatformMove();
            //GameManager.Instance.MovedPlatformConroller.PlatformMove(); 
            #endregion
            GameManager.Instance.MovedPlatformConroller.PlatformMove();
            GameManager.Instance.CurrentLevel++;
            GameManager.Instance.SaveManager.Level = GameManager.Instance.CurrentLevel;
            GameManager.Instance.SaveManager.Save();
            GameManager.Instance.GameStatusCache = GameStatus.NEXTLEVEL;
        }
        else
        {
            platformLevelUI.GetComponent<Image>().color = Color.red;
            GameManager.Instance.GameStatusCache = GameStatus.END;
        }
    }
}
