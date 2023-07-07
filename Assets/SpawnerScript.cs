using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public float spawnRate = 2;
    public float timer = 0;
    public GameObject bush;

    // Start is called before the first frame update
    void Start()
    {
     
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        } else
        {
            Instantiate(bush, transform.position, transform.rotation);
            timer = 0;
        }
       
    }
}
