using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlayerThawBehavier : FireBehavier
{
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        MoveStraight();

        DestoryOutBoundry();
    }
}
