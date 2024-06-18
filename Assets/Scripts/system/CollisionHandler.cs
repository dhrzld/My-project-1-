using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Car"))
        {
            
            GameManager.Instance.GameOver();
        }
    }
}
