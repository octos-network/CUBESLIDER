using UnityEngine;

public class PlayerCollition : MonoBehaviour
{
    public PlayerMovement movement;
   

    void OnCollisionEnter (Collision collisionInfo) 
    {
       if (collisionInfo.collider.tag == "Obstacle") 
       {
           movement.enabled = false;
           FindObjectOfType<GameManager>().EndGame();
       }
    }
}