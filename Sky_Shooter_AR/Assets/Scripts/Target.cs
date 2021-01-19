using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField]private float healt;
    [SerializeField] private int score;
    

    public float Healt
    {
        get => healt;
        set => healt = 100.0f;
    }
    private void Start()
    {
      
    }
    public void TakeDamage(float amount)
    {
        
        healt -= amount;
        //Debug.Log("damagetaken");
        //Debug.Log(healt);
        if (healt <= 0)
        {
            upScore();
        }
    }
    void upScore()
    {
        ScoreUI.input_Score(score);
       
        die();
    }
    void die()
    {
        //Debug.Log("die");
        this.gameObject.SetActive(false);
    }
   
}
