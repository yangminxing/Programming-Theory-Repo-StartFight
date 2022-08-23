using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireThawBehavier : FireBehavier
{
    private void Start()
    {
        moveSpeed = 2;
    }

    void Update()
    {
        MoveStraight();

        DestoryOutBoundry();
    }
}
