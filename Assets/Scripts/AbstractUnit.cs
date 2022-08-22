using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractUnit : MonoBehaviour
{
    private float moveSBoundry = -4.6f;
    private float moveNBoundry = 4.4f;
    protected float moveEBoundry = 3.1f;
    private float moveWBoundry = -3.1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void LimitBoundry()
    {
        if (gameObject.transform.position.x < moveWBoundry)
        {
            gameObject.transform.position = new Vector3(moveWBoundry, gameObject.transform.position.y);
        }

        if (gameObject.transform.position.x > moveEBoundry)
        {
            gameObject.transform.position = new Vector3(moveEBoundry, gameObject.transform.position.y);
        }

        if (gameObject.transform.position.y < moveSBoundry)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, moveSBoundry);
        }

        if (gameObject.transform.position.y > moveNBoundry)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, moveNBoundry);
        }
    }
}
