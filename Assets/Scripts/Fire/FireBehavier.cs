using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBehavier : AbstractUnit
{

    public float damage;

    protected float moveSpeed;
    // define who open fire
    private AbstractUnit m_source;

    //  define who get fired
    private AbstractUnit m_target;

    private Vector3 originSourcePos;
    private Vector3 originTargetPos;

    private bool hasTrack;

    private void LateUpdate()
    {
       
    }

    public void MoveStraight()
    {
        if (m_target != null)
        {
            Vector2 direction = new Vector2(originTargetPos.x - originSourcePos.x, originTargetPos.y - originSourcePos.y);

            gameObject.transform.up = direction;
            gameObject.transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
        }
        gameObject.transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
    }

    protected void MoveTrack()
    {
        if (m_target != null && m_source != null)
        {
            Vector2 direction = new Vector2(m_target.transform.position.x - m_source.transform.position.x, m_target.transform.position.y - m_source.transform.position.y);

            gameObject.transform.up = direction;
            gameObject.transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);

            hasTrack = true;
        }
        else if (hasTrack) {
            Destroy(gameObject);
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
