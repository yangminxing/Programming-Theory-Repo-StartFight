using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBehavier : AbstractUnit
{
    protected float moveSpeed;
    protected float damage;

    // define who open fire
    private AbstractUnit m_source;

    //  define who get fired
    private AbstractUnit m_target;

    private Vector3 originSourcePos;
    private Vector3 originTargetPos;

    private bool isTrack = false;


    private void LateUpdate()
    {
        DestoryOutBoundry();
    }

    protected void MoveStraight()
    {
        if (originTargetPos != null)
        {
            Vector2 direction = new Vector2(originTargetPos.x - originSourcePos.x, originTargetPos.y - originSourcePos.y);

            gameObject.transform.up = direction;
            gameObject.transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
        }
    }

    protected void MoveTrack()
    {
        if (originTargetPos != null)
        {
            Vector2 direction = new Vector2(m_target.transform.position.x - m_source.transform.position.x, m_target.transform.position.y - m_source.transform.position.y);

            gameObject.transform.up = direction;
            gameObject.transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
        }
    }

    public void SetSourceAndTarget(AbstractUnit source, AbstractUnit target)
    {
        m_source = source;
        m_target = target;

        originSourcePos = m_source.transform.position;
        originTargetPos = m_target.transform.position;
    }

}
