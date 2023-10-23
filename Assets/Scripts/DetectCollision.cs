using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    private AudioSource audioSource; 


    private void Start()
    {
        audioSource = GetComponent<AudioSource>(); ;
    }

    private void OnTriggerEnter(Collider other)
    {
        
        audioSource.Play();
        Destroy(other.gameObject);
        Destroy(gameObject);

        Debug.Log("Audio triggered");
 
        
    }

    
}
