using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoreText;
    public static int score1;
    public static int highscore;
    public Text highscoretext;
    // Start is called before the first frame update
    void Start()
    {
        score1 = 0; 
    }

    // Update is called once per frame
    
    void Update()
    {
        if(score1>highscore)
        {
            highscore=score1;
        }
        scoreText.text="Score: "+score1;  
        highscoretext.text="HighScore: "+ highscore;  
        
    }

    }