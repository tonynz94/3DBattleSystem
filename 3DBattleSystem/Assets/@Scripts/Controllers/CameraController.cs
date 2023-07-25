using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    void LateUpdate()
    {
        switch(Managers.Game.CameraMode)
        {
            case Define.CameraMode.None:
                break;
            case Define.CameraMode.Normal: 
                break;
            case Define.CameraMode.Battle:
                break;
            case Define.CameraMode.Dead:
                break;
        }
    }
}
