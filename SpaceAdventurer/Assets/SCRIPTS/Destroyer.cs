﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void OnCollisionEnter2D(Collision2D coll) 
    {
        if (coll.gameObject.tag == "Enemy" || coll.gameObject.tag == "moneyg" ||coll.gameObject.tag == "moneys" )
        Destroy(coll.gameObject);

    }
}