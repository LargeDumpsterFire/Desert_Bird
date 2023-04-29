using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    //referencing
    public Rigidbody2D myrigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public bool birdFlap = false;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Birb";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        anim = gameObject.GetComponent<Animator>();
      
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0) == true && birdIsAlive || Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive)
        {
            anim.SetTrigger("Active");
            myrigidbody.velocity = Vector2.up * flapStrength; // short hand for vector2(0,1)
        }
        else
        {
            anim.SetTrigger("Inactive");
        }
        if (transform.position.y > 13 || transform.position.y < -13)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
        


    }
        private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
    public void Globals()
    {
        bool globalBirdIsAlive = birdIsAlive;
    }


}
