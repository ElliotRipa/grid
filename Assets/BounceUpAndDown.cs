using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceUpAndDown : MonoBehaviour
{

    Vector3 movementDirection;
    public float moveSpeed;

    public float lowerY = -2.4F;
    public float upperY = 2.4F;

    // Start is called before the first frame update
    void Start()
    {
        
        if(transform.position.y < 0)
        {
            movementDirection = Vector3.up;
        }
        else
        {
            movementDirection = Vector3.down;
        }

    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.y < lowerY)
        {
            movementDirection = Vector3.up;
        }
        else if(transform.position.y > upperY)
        {
            movementDirection = Vector3.down;
        }

        transform.position += movementDirection * Time.deltaTime * moveSpeed;
    }
}
