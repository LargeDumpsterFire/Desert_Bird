using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static LogicScript;
public class PipeMoveScript : MonoBehaviour
{   
    public float getScore;
    public float speedMult = 0;
    public float moveSpeed;
    public float deadzone = -45;
    // Start is called before the first frame update
    void Start()
    {
        getScore = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>().playerScore;
         Debug.Log("Score is: " + getScore);
        moveSpeed++;
        Debug.Log("move speed is: " + moveSpeed);

    }

    // Update is called once per frame
    void Update()
    {
       
        transform.position = transform.position + (Vector3.left * moveSpeedUp()) *Time.deltaTime;
        

        if (transform.position.x < deadzone)
        {
            Debug.Log("Pipe is DELETED");
            Destroy(gameObject);
        }

        
    }
   float moveSpeedUp()
    {
        if (getScore % 10 == 0)
        {
            moveSpeed++;
            Debug.Log("move speed is: " + moveSpeed);
            return moveSpeed;
        }
        else
        {
            
            Debug.Log("move speed is: " + moveSpeed);
            return moveSpeed;
        }
    }
   
}
