using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class castleHealth : MonoBehaviour
{
    public float healtcas;
    public float maxhealtcas = 7000.0f;
    public GameObject UIend;    
    public Slider slide;
    public Text text;
    public AudioClip impact;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //UIend = GameObject.FindGameObjectWithTag("UI_end");
        slide.value = healtcas;
        healtcas = maxhealtcas;
        slide.maxValue = maxhealtcas;
        text.text = healtcas.ToString() + "/" + maxhealtcas.ToString();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Damage(float amount)
    {
        //print(slide.value);
        healtcas -= amount;
        // print(healtcas);
        text.text = healtcas.ToString()+"/"+maxhealtcas.ToString();
        showHealth();

    }
    public void showHealth()
    {
        slide.value = healtcas;
        if (healtcas <= 0)
        {
            audioSource.PlayOneShot(impact, 0.7F);
            UIend.SetActive(true);
            Time.timeScale = 0.0f;          
        }
    }

}
