using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_monsters : MonoBehaviour
{    
    public GameObject[] monsters;
    public Transform[] spawnPosit;
    public GameObject parent;
    public float time = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn_Mons", 2.0f, time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn_Mons()
    {

        int ranMons = Random.Range(0, monsters.Length);
        int ranSP = Random.Range(0, spawnPosit.Length);

       GameObject bot = Instantiate(monsters[ranMons], spawnPosit[ranSP].position, Quaternion.identity);
        bot.transform.parent = parent.transform;
        
    }
    
}
