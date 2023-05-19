using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public float lowerX = -8.1F;
    public float upperX = 8.1F;
    public float lowerY = -4.4F;
    public float upperY = 4.4F;

    public float moveFrequency = 1.0f;
    private float timer = 0;

    public float moveSpeed = 0.5f;

    private List<Vector3> directions = new List<Vector3> { Vector3.up, Vector3.down, Vector3.left, Vector3.right };



    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-6, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < moveFrequency)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Move();
            // Debug.Log(transform.position);
            timer = 0;
        }
    }

    void Move()
    {
        Vector3 direction = directions[Random.Range(0, directions.Count)];
        Vector3 newPosition = transform.position + direction;
        if (newPosition.y > lowerY && newPosition.x > lowerX && newPosition.y < upperY && newPosition.x < upperX)
        {
            transform.position = newPosition;
        }
    }

}
