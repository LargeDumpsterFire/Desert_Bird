using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static LogicScript;
public class PipeMoveScript : MonoBehaviour
{   
    public float getScore;
    public float speedMult = 0;
    public float moveSpeed = 5;
    public float deadzone = -45;
    // Start is called before the first frame update
    void Start()
    {
        getScore = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>().playerScore;
         Debug.Log("Score is: " + getScore);
        if (getScore % 10 == 0 && getScore != 0)
        {
           moveSpeed = moveSpeed + 1;
            Debug.Log("move speed is: " + moveSpeed);

        }

    }

    // Update is called once per frame
    void Update()
    {
       
        transform.position = transform.position + (Vector3.left * moveSpeed ) * Time.deltaTime;
        

        if (transform.position.x < deadzone)
        {
            Debug.Log("Pipe is DELETED");
            Destroy(gameObject);
        }

        /* public float moveSpeedMult()
        {
            if (playerScore % 10 == 0 && playerScore != 0)
            {
                speedMult++;
                Debug.Log("Speed is: " + speedMult);

            }
            return speedMult;
        }*/
    }
    
}
