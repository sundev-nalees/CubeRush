using UnityEngine;

public class playercollision : MonoBehaviour
{
    [SerializeField] private GameManager gM; 
    public playermovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag=="obstacle")
        {
            movement.enabled = false;
            gM.EndGame();
            
        }
    }
}
