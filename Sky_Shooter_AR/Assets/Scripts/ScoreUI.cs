using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    static int score;
    public Text score_text;
    public Text[] score_end;
   


    // Start is called before the first frame update
    void Start()
    {

        score = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = "Score:"+score.ToString();
        score_end[0].text= score.ToString();
        score_end[1].text = score.ToString();
       
    }
   static public void input_Score(int s)
    {
        
        score += s;

    }
}
