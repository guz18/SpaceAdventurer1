using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundaries : MonoBehaviour
{
   
     private float minX, maxX;

    // Start is called before the first frame update
     void Start () {
       float camDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
         Vector2 bottomCorner = Camera.main.ViewportToWorldPoint(new Vector3(0,0, camDistance));
         Vector2 topCorner = Camera.main.ViewportToWorldPoint(new Vector3(1,1, camDistance));
         minX = bottomCorner.x;
         maxX = topCorner.x;

    }

    // Update is called once per frame
    void Update(){
      // Get current position
         Vector3 pos = transform.position;
 
         // Horizontal contraint
         if(pos.x < minX + 0.6f) pos.x = minX + 0.6f  ;
         if(pos.x > maxX - 0.6f) pos.x = maxX - 0.6f ;
 
         // Update position
         transform.position = pos;
    }
}
