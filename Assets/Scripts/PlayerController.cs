using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/*********
 * component of the player, controls player movement.
 * 
 * Alexandra Collier-Lake
 * 10/03/2005
 **********/



public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    private float speed;
    private float centerToEdge = 35;
    private float move;


    // Start is called before the first frame update
    void Start()
    {
        speed = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement(); //call playerMovement each frame
    }

    private void PlayerMovement()
    {
        
        if(transform.position.x >= -centerToEdge && transform.position.x <= centerToEdge)
        {
            
                transform.Translate(Vector3.right * Time.deltaTime * speed * move);
            

            //transform.position = new Vector3(centerToEdge, transform.position.y, transform.position.z);
        }

    }

    private void OnMove(InputValue input)
    {
        Vector2 vector = input.Get<Vector2>();

        move = vector.x;
        Debug.Log(move);
    }

    private void OnFire()
    {
        Instantiate(projectile, transform.position + Vector3.up, projectile.transform.rotation);
    }
}
