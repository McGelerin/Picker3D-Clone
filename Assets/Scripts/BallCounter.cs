using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCounter : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Ball"))
        {
            GameManager.Instance.BallCount++;
//            col.gameObject.tag = "UntaggedBall";
        }
    }
}
