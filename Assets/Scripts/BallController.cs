using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Counter"))
        {
            StartCoroutine(WaitBallDestroy());
        }
    }

    IEnumerator WaitBallDestroy()
    {
        yield return new WaitForSeconds(2f);
        gameObject.GetComponent<SphereCollider>().enabled = false;
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
