using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    #region MyRegion
    //BallCounter _ballCounter;
    //private int _currentPlatform;

    //[SerializeField] Text platformText1;
    //[SerializeField] Text platformText2;
    //[SerializeField] Text platformText3; 
    #endregion
    [SerializeField] Button playButton;
    public Text[] PlatformText;
    [SerializeField] GameObject endPanel;


    [SerializeField] Text nowText, nextText;

    public void Play()
    {
        playButton.gameObject.SetActive(false);
        GameManager.Instance.GameStatusCache = GameStatus.PLAY;
    }

    public void Reset()
    {
        GameManager.Instance.GameStatusCache = GameStatus.NONE;
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }


    private void Start()
    {
        PlayButtonOn();
        textWriter();
        //_currentPlatform = GameManager.Instance.CurrentPlatform - 1;
        endPanel.gameObject.SetActive(false);
        PlatformTextWriter(GameManager.Instance.CurrentPlatform);
    }

    private void LateUpdate()
    {
        if (GameManager.Instance.GameStatusCache == GameStatus.CONTROL || GameManager.Instance.GameStatusCache == GameStatus.PLAY)
        {
            PlatformTextWriter(GameManager.Instance.CurrentPlatform);
        }
        else if (GameManager.Instance.GameStatusCache == GameStatus.END)
        {
            endPanel.gameObject.SetActive(true);
        }
    }

    private void PlayButtonOn()
    {
        if(GameManager.Instance.GameStatusCache == GameStatus.NONE)
        {
            playButton.gameObject.SetActive(true);
        }
    }


    public void PlatformTextWriter(int currentPlatform)
    {
        PlatformText[currentPlatform].text = LevelController.Platform[currentPlatform].ToString() + "/" + GameManager.Instance.BallCount.ToString();
        //platformText1.text = MissionController.Platform[currentPlatform] +" / "+ GameManager.Instance.BallCount.ToString();
    }

    private void textWriter()
    {
        nowText.text = (GameManager.Instance.CurrentLevel + 1).ToString();
        nextText.text = (GameManager.Instance.CurrentLevel + 2).ToString();


    }

}
