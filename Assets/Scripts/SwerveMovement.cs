using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveMovement : SwerveInputSystem
{
    [SerializeField] private SwerveType swerveType;
    private float _swerveSpeed;
    private float _maxSwerveAmount;
    private float _maxMove_x;
    private Rigidbody _playerRb;

    private void Start()
    {
        _swerveSpeed = swerveType.SwerveSpeed;
        _maxSwerveAmount = swerveType.MaxSwerveAmount;
        _maxMove_x = swerveType.MaxMove_x;
        //_playerRb = GameManager.Instance.PlayerController.playerRb;
    }

    public void SwerveMove(Rigidbody playerRb)
    {
        _playerRb = playerRb;
        ChechTouches();
        float _swerveAmount = /*Time.deltaTime **/_swerveSpeed * /*swerveInputSystem.*/MoveFactorX;
        _swerveAmount = Mathf.Clamp(_swerveAmount, - _maxSwerveAmount, _maxSwerveAmount);
        _swerveAmount = EdgeController(_swerveAmount);
        _playerRb.velocity = new Vector3(_swerveAmount, _playerRb.velocity.y, _playerRb.velocity.z);
        #region MyRegion
        //SpeedLimitter();
        //playerRb.AddForce(Vector3.right * _swerveAmount,ForceMode.Impulse);
        //playerRb.MovePosition(playerRb.transform.position + (Vector3.right*_swerveAmount));


        //ChechTouches(); 
        #endregion
    }

    public float EdgeController(float swerveAmount)
    {
        #region MyRegion
        //float _xPosition = playerRb.transform.position.x;

        //if (_xPosition <= -(_maxMove_x))
        //{
        //    //playerRb.velocity = new Vector3(0, playerRb.velocity.y, playerRb.velocity.z);
        //    swerveAmount = Mathf.Clamp(swerveAmount, 0, _maxSwerveAmount);
        //    return swerveAmount;
        //}
        //else if (_xPosition >= _maxMove_x)
        //{
        //    playerRb.velocity = new Vector3(0, playerRb.velocity.y, playerRb.velocity.z);
        //    swerveAmount = Mathf.Clamp(swerveAmount, -(_maxSwerveAmount), 0);
        //    return swerveAmount;
        //} 
        #endregion

        swerveAmount = LeftLimitter(swerveAmount);
        swerveAmount = RightLimitter(swerveAmount);
        return swerveAmount;
    }

    public float LeftLimitter(float swerveAmount)
    {
        float _xPosition = _playerRb.transform.position.x;
        if (_xPosition <= -(_maxMove_x))
        {
            _playerRb.velocity = new Vector3(0, _playerRb.velocity.y, _playerRb.velocity.z);
            swerveAmount = Mathf.Clamp(swerveAmount, .1f, _maxSwerveAmount);
            return swerveAmount;
        }
        return swerveAmount;
    }
    public float RightLimitter(float swerveAmount)
    {
        float _xPosition = _playerRb.transform.position.x;
        if (_xPosition >= _maxMove_x)
        {
            _playerRb.velocity = new Vector3(0, _playerRb.velocity.y, _playerRb.velocity.z);
            swerveAmount = Mathf.Clamp(swerveAmount, -(_maxSwerveAmount), -.1f);
            return swerveAmount;
        }
        return swerveAmount;
    }

    #region MyRegion
    //public void SpeedLimitter()
    //{
    //    if (playerRb.velocity.x > _maxSwerveAmount)
    //    {
    //        //playerRb.velocity.x = playerRb.velocity * _maxSwerveAmount;
    //        playerRb.velocity.x = Vector3.ClampMagnitude(playerRb.velocity., _maxSwerveAmount);
    //    }
    //} 
    #endregion
}
