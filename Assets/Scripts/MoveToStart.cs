using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToStart : MonoBehaviour
{
    [SerializeField] GameObject startPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.GameStatusCache = GameStatus.PLAY;
            SceneManager.LoadScene(0);

        }
    }
}
