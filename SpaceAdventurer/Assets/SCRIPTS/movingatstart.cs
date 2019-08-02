using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingatstart : MonoBehaviour
{
    Vector3 characterScale;
    float characterScaleX;
    public float movementSpeed = 10;
    private float minX, maxX, minY, maxY;
    private float lastY;
    private Vector3 endPosition;
    // Use this for initialization
    void Start() {
        float camDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
        Vector2 bottomCorner = Camera.main.ViewportToWorldPoint(new Vector3(0,0, camDistance));
        Vector2 topCorner = Camera.main.ViewportToWorldPoint(new Vector3(1,1, camDistance));
        minX = bottomCorner.x;
        maxX = topCorner.x;
        minY = bottomCorner.y;
        maxY = topCorner.y;
        lastY=(maxY-minY)/5+minY;

    }
 
    // Update is called once per frame
    void Update() {
        Vector3 pos = transform.position;
        pos.y=lastY;
        endPosition = new Vector3(0, lastY, 0);
        if(transform.position.y != endPosition.y) {
            transform.position = Vector3.MoveTowards(transform.position, endPosition, movementSpeed * Time.deltaTime/5);
        }
        

       

    }
}
