using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapstrength;
    public LogicScript logic;
    public bool birdisalive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Space) && birdisalive) 
        {
            myRigidBody.velocity = Vector2.up * flapstrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        birdisalive = false;
    }
}
