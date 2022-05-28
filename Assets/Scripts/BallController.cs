using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y > 0.27f)
        {
            transform.position = new Vector3(transform.position.x, 0.27f, transform.position.z);
        }

    }
}
