using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="New Magnet Type",menuName ="Magnet")]
public class MagnetType : ScriptableObject
{
    public int MagnetSpeed;
    public Color MagnetColor;
    public Vector3 MagnetScale;
}
