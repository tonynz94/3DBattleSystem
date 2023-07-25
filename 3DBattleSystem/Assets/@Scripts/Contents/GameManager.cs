using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using static Define;
using Random = UnityEngine.Random;

public class GameManager
{
    bool _bgmOn;
    bool _effectSountOn;

    Define.CameraMode _cameraMode = CameraMode.None;

    public PlayerController Player { get; set; }

    public Define.CameraMode CameraMode
    {
        get
        {
            return _cameraMode;
        }
        set
        {
            if (_cameraMode == value)
                return;
        }
    }

    public bool BGMOn
    {
        get
        {
            return _bgmOn;
        }
        set
        {
            _bgmOn = value;
        }
    }

    public bool EffectSoundOn
    {
        get
        {
            return _effectSountOn;
        }
        set
        {
            _effectSountOn = value;
        }
    }
}

