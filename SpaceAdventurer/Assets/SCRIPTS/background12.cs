using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background12 : MonoBehaviour
{
    public int k,t=1;
    private Rigidbody2D Rigidbody;
    private float m_speed = -1.5f;
    [SerializeField] private bool  stopScrolling;
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        Rigidbody.velocity = new Vector2(0, m_speed);
        
    }

    void Update()
    {
        if(stopScrolling)
        {
            Rigidbody.velocity = Vector2.zero;
        }

        else
        {
            Rigidbody.velocity = new Vector2(0, m_speed);  
        }

        if(score.score1>=15*t && score.score1>1 && k==1)
                {
                   m_speed+=m_speed/2f;
                   k++;
                   t++;
                }
        else if(score.score1/15!=0 &&score.score1>1){
            k=1;
        }
    }
}
