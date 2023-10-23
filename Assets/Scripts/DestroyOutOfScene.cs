using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfScene : MonoBehaviour
{
    private float upperBound;
    private float lowerBound;

    // Start is called before the first frame update
    void Start()
    {
        upperBound = 40.0f;
        lowerBound = -10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        DestroyOutOfBounds();
    }

    private void DestroyOutOfBounds()
    {
        if(gameObject.transform.position.z > upperBound || gameObject.transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
            endGame();
        }
    }

    private void endGame()
    {
        Time.timeScale = 0;
    }
}
