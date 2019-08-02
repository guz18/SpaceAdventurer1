using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSpawn : MonoBehaviour
{
    public int k;
    int number=1;
    int carNo;
    Vector3 characterScale;
    float characterScaleX;
    private float minX, maxX, minY, maxY;
    private Vector3 endPosition;
    public GameObject[] cars;
    public static float delayTimer = 3f, speeding;
    public int g, t=1;
    float timer;
    void Start()
    {
        timer = delayTimer;
        float camDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
        Vector2 bottomCorner = Camera.main.ViewportToWorldPoint(new Vector3(0,0, camDistance));
        Vector2 topCorner = Camera.main.ViewportToWorldPoint(new Vector3(1,1, camDistance));
        minX = bottomCorner.x;
        maxX = topCorner.x;
        minY = bottomCorner.y;
        maxY = topCorner.y;
        speeding = delayTimer;

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer<=0)
        {
            Vector3 carPos = new Vector3(Random.Range(minX+0.6f,maxX-0.7f),transform.position.y,transform.position.z);
            carNo=Random.Range(0,3);

            Instantiate (cars[carNo],carPos,transform.rotation);
            timer = delayTimer;
            number+=1;
        }
        g=score.score1;
            if(score.score1>=15*t && score.score1>1 && k==1)
                {
                   speeding-=speeding/3f;
                   delayTimer=speeding;
                   k++;
                   t++;
                }
                else if(score.score1/15!=0 &&score.score1>1){
                k=1;
                }
    }
}
