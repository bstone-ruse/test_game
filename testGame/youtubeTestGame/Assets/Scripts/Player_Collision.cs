using UnityEngine;

public class Player_Collision : MonoBehaviour
{
    //reference a script 
    public Player_Movement movement;


    void OnCollisionEnter(Collision collisionInfo)
    {
       // Debug.Log("we hit something");

       //Debug.Log(collisionInfo.collider.name);
        
        if(collisionInfo.collider.tag == "Obsticle")
        {

            movement.enabled = false; //disable player movement

            FindObjectOfType<GameManager>().EndGame();
            
        }

        if (collisionInfo.collider.tag == "END")
        {
            FindObjectOfType<GameManager>().CompleteLevel();
        }
    }



}	
