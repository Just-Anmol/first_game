using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float birdStrength;
    public LogicScript logic;
    public bool isBirdAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) && isBirdAlive) 
        {
            myRigidbody.velocity = Vector2.up * birdStrength;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isBirdAlive=false;
    }
}
