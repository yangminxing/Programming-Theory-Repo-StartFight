using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractUnit : MonoBehaviour
{
    protected float moveNBoundry = 4.4f;
    protected float moveSBoundry = -4.6f;
    protected float moveEBoundry = 3.1f;
    protected float moveWBoundry = -3.1f;

    protected float moveOutNBoundry = 7f;
    protected float moveOutSBoundry = -6f;
    protected float moveOutEBoundry = 5f;
    protected float moveOutWBoundry = -5f;
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

    protected void DestoryOutBoundry()
    {
        if (gameObject.transform.position.x > moveOutEBoundry)
        {
            Destroy(gameObject);
        }

        if (gameObject.transform.position.x < moveOutWBoundry)
        {
            Destroy(gameObject);
        }

        if (gameObject.transform.position.y > moveOutNBoundry)
        {
            Destroy(gameObject);
        }

        if (gameObject.transform.position.y < moveOutSBoundry)
        {
            Destroy(gameObject);
        }
    }
}
