using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBehavier : MonoBehaviour
{
    // define who open fire
    private AbstractUnit m_source;

    //  define who get fired
    private AbstractUnit m_target;

    protected float moveSpeed = 40;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireTo(AbstractUnit unit) {
        if (m_source == null || m_target == null) {
            Debug.LogError("You must assign the source and target!");
            return;
        }

        gameObject.transform.Translate((m_target.transform.position - m_source.transform.position).normalized * Time.deltaTime * moveSpeed);
    }
}
