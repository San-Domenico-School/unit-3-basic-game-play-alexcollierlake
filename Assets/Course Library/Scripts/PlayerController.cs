using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    private float speed;
    private float centerToEdge;
    private float move;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayerMovement()
    {
        //to be implemented
    }

    private void OnMove(InputValue input)
    {
        //to be implemented
    }

    private void OnFire()
    {
        //to be implemented 
    }
}
