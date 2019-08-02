using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldmoney : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1.5f;
    public int k,t=1;

    private void Start()
    {
        speed = 2f;
    }
    void Update()
    {
                transform.Translate(new Vector3(0,1,0) * speed * Time.deltaTime);
                if(score.score1>=15*t && score.score1>1 && k==1)
                {
                   speed+=speed/3f;
                   k++;
                   t++;
                }
                else if(score.score1/15!=0 &&score.score1>1){
                k=1;
                }
    }
}
