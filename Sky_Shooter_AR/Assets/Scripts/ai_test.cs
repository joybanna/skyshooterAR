using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ai_test : MonoBehaviour
{
    [SerializeField]private float ranghit;
    [SerializeField] private float DMG;
    private Animator anim;
    private GameObject end_Point;
    private NavMeshAgent nav;



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        nav = GetComponent<NavMeshAgent>();
        end_Point = GameObject.FindGameObjectWithTag("endpoint");
        end_Point.GetComponent<BoxCollider>().enabled=true;
        
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(end_Point.transform.position);

        RaycastHit hit;       
        Debug.DrawRay(this.transform.position, this.transform.forward * ranghit, Color.yellow);
        if(Physics.Raycast(this.transform.position, this.transform.forward, out hit,ranghit))
        {
            if (hit.transform == end_Point.transform)
            {
                anim.SetBool("isAttack", true);
                print(hit.transform);
                des(DMG);
                
            }
            
        }
    }
 
    private void des(float D)
    {
        castleHealth s = GameObject.FindGameObjectWithTag("castle").GetComponent<castleHealth>();
        s.Damage(DMG);
        Destroy(this.gameObject);
    }


}
