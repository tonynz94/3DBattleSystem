using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : CreatureController
{
    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        return true;
    }

    public override void UpdateController()
    {

    }
}
