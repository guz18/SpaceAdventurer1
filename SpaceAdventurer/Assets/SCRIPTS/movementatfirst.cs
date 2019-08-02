using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movementatfirst : MonoBehaviour
{
    public Button[] buttons;
    bool gameOver;
    Vector3 characterScale;
    float characterScaleX;
    


    void Start()
    {

        characterScale = transform.localScale;
        characterScaleX = characterScale.x;
    }
    void Update()
    {
              // Move the Character:
        transform.Translate(Input.GetAxis("Horizontal") * 11f * Time.deltaTime, 0f, 0f);

        // Flip the Character:
        if (Input.GetAxis("Horizontal") < 0) {
            characterScale.x = -characterScaleX;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = characterScaleX;
        }
        transform.localScale = characterScale;


    }
        void OnCollisionEnter2D(Collision2D coll) 
    {
        if (coll.gameObject.tag == "Enemy"){
        Destroy(gameObject);
        gameOverActivated();

        }
    
        else if(coll.gameObject.tag == "moneyg")
        {
        score.score1 += 3;
        Destroy(coll.gameObject);
        }
        else if(coll.gameObject.tag == "moneys")
        {
        score.score1 += 1;
        Destroy(coll.gameObject);
        }
    }
    public void gameOverActivated()
    {
        gameOver = true;
        foreach (Button button in buttons){
            button.gameObject.SetActive(true);
        }
    }
    }
