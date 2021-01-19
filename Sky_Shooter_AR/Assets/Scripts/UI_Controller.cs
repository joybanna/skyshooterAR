using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Controller : MonoBehaviour
{
    [SerializeField] private GameObject impactFX;
    [SerializeField] private int damagegun;
    private GameObject ui_vofuria;
    public GameObject spawnpoint;
    public GameObject uigame;
    public GameObject hidbut;
    //public int armo=20;
    private Camera AR_cam;
    private float rangshoot = 10.0f;
    public AudioClip impact;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //spawnpoint = GameObject.FindGameObjectWithTag("spawn");

        ui_vofuria = GameObject.FindGameObjectWithTag("UI_vofuria");
        AR_cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        audioSource = GetComponent<AudioSource>();

        //uigame = GameObject.FindGameObjectWithTag("UI_game");
        //hidbut = GameObject.FindGameObjectWithTag("UI_hide");



        hidbut.SetActive(true);
        uigame.SetActive(false);
        spawnpoint.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(AR_cam.transform.position, AR_cam.transform.forward*rangshoot,Color.red);
    }

    public void Hide_UI()
    {
        hidbut.SetActive(false);
        uigame.SetActive(true);
        spawnpoint.SetActive(true);
        ui_vofuria.SetActive(false);
    }
    public void Shoot()
    {

        audioSource.PlayOneShot(impact, 0.7F);
        //armo--;
        //print("press");        
        RaycastHit hit;
        if(Physics.Raycast(AR_cam.transform.position, AR_cam.transform.forward, out hit, rangshoot))
        {
            //Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                //Debug.Log(target.transform.name);
                target.TakeDamage(damagegun);
            }
            Instantiate(impactFX, hit.point, Quaternion.LookRotation(hit.normal));
        }
        
    }

}
