using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallBehavier : FireBehavier
{
    private void Start()
    {
        moveSpeed = 3;
    }

    void Update()
    {
        MoveStraight();
    }
}
