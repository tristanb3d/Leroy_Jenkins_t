using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmspawn : MonoBehaviour
{

    public GameObject Spawndenm;
    public Transform t;
    public float SpawnTimer ;
    public float SpawnWait;
    public int SpawnLimit ;  


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", SpawnTimer, SpawnWait);
    }

    // Update is called once per frame
    void Spawn ()
    {
       
        //  bool SpawnStop;
        if (SpawnLimit < 25)
        {
            
            Instantiate(Spawndenm, transform.position, transform.rotation);
            SpawnLimit += 1;
        }
        // if (SpawnStop)
        //   {
        //         CancelInvoke("Spawn");
        //     }

    }




}
