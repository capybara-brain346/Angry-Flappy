using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 2;
    public float timer = 0;
    public float heightoffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnpipe();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer = 0;
        }
       
    }
    void spawnpipe()
    {
        float lowerpoint = transform.position.y - heightoffset;
        float highestpoint = transform.position.y + heightoffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowerpoint,highestpoint),0), transform.rotation);

    }
}
