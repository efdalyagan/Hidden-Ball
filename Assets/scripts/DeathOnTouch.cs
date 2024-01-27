using UnityEngine;

public class DeathOnTouch : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
           
        }
    }
}
