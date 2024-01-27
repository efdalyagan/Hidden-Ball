using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public GameObject gameObject1;


    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
           
            Die();
        }
    }

    void Die()
    {
       
        Destroy(gameObject1);
    }
}
