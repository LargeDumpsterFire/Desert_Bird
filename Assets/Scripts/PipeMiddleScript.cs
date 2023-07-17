using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    
    public LogicScript logic;
    public BirdScript birdAlive;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        birdAlive = GameObject.FindGameObjectWithTag("Birb").GetComponent<BirdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //will run whenever something touches the trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.layer == 3 && birdAlive.birdIsAlive==true)
        {
           // Debug.Log("score added");
            logic.addScore(1);
           
        } 
        
    }
}
