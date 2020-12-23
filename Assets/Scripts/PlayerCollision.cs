using System.Diagnostics;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

   void OnCollisionEnter (PlayerCollision collisionInfo)
    {
        if (collisionInfo.GetComponent<Collider>().tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<Game_Manager>().EndGame();
           
        }
    }

}
