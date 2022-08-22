using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMissleBehavier : FireBehavier
{
    // Start is called before the first frame update
    private void Start()
    {
        moveSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        MoveTrack();
    }
}
