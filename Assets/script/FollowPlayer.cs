using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
   [SerializeField] private Transform player;
   [SerializeField] private Vector3 offset;


    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = player.position + offset;
    }
}
