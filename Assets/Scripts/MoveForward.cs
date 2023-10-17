using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [Range(5, 30)] [SerializeField] private float speed;


    // Update is called once per frame
    void Update()
    {
        MoveAnimalForward();
    }

    void MoveAnimalForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
