using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] MagnetType magnetType;
    [SerializeField] Rigidbody playerRb;
    float _magnetSpeed;
    SwerveMovement _swerveMovement;
    //public Collider Col;
    //public bool Trigger;
    void Start()
    {
  //      Trigger = true;
        _swerveMovement = FindObjectOfType<SwerveMovement>();
        _magnetSpeed = magnetType.MagnetSpeed;
    }

    private void FixedUpdate()
    {
        #region MyRegion
        //if (/*Input.GetKey(KeyCode.Space)*/  )
        //{
        //    playerRb.velocity = new Vector3(playerRb.velocity.x, playerRb.velocity.y, 0);

        //}
        /*else*/
        //OnTriggerEnter(Col); 
        #endregion
        if (GameManager.Instance.GameStatusCache == GameStatus.PLAY || GameManager.Instance.GameStatusCache == GameStatus.NEXTLEVEL)
        {
            Moment();
            _swerveMovement.SwerveMove(playerRb);
        }
        else if (GameManager.Instance.GameStatusCache == GameStatus.CONTROL)
        {
            playerRb.velocity = new Vector3(0,0,0);
        }
    }

    private void Moment()
    {
        playerRb.velocity = new Vector3(playerRb.velocity.x, playerRb.velocity.y, _magnetSpeed);
    }
    #region MyRegion
    //   private void OnTriggerEnter(Collider other)
    //   {
    //       //Debug.Log("Collider girdi");
    //       if (other.gameObject.tag == "Player")
    //       {
    //           Debug.Log("Girdi");
    ////           Trigger = false;
    //           playerRb.AddForce(Vector3.forward * 10f, ForceMode.Force);
    //           playerRb.velocity = new Vector3(playerRb.velocity.x, playerRb.velocity.y, 0);
    //       }
    //   } 
    #endregion
}
