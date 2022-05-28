using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] Rigidbody ballRb;
    [SerializeField] float force;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.GameStatusCache = GameStatus.CONTROL;
            //ballRb.AddForce(Vector3.forward*force,ForceMode.Force); ;
            StartCoroutine(Waiter());
            //if (other.CompareTag("Ball"))
            //{
            //    other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * force/*, ForceMode.Impulse*/);
            //}


            //GameManager.Instance.GameStatusCache = GameStatus.PLAY;
        }


    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * force/*, ForceMode.Impulse*/);
        }
    }

    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(5f);


    }





}
