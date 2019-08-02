using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatingbackground1 : MonoBehaviour
{
    private BoxCollider2D m_backgroundcollider;
    private float m_backgroundSize;
    void Start()
    {
        m_backgroundcollider = GetComponent<BoxCollider2D>();
        m_backgroundSize = m_backgroundcollider.size.y;
    }

    
    void Update()
    {
        if(transform.position.y < -m_backgroundSize)
        {
            RepeatBackground();
        }
    }

    void RepeatBackground()
    {
        Vector2 BGOffset = new Vector2(0,m_backgroundSize * 3f );
        transform.position = (Vector2)transform.position + BGOffset;
    }
}
