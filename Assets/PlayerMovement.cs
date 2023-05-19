using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 10;
    public int health;
    AudioSource sounds;
    public AudioSource deathSound;
    public AudioSource hitSound;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        health = 5;
        sounds = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += getDirection() * moveSpeed * Time.deltaTime;
    }

    private Vector3 getDirection()
    {

        Vector3 dir = Vector3.zero;

        if (Input.GetKey(KeyCode.LeftArrow)) { dir += Vector3.left; }
        if (Input.GetKey(KeyCode.RightArrow)) { dir += Vector3.right; }
        if (Input.GetKey(KeyCode.DownArrow)) { dir += Vector3.down; }
        if (Input.GetKey(KeyCode.UpArrow)) { dir += Vector3.up; }
        return dir;
    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("You took damage!" + health);
        hitSound.Play();
        health--;

        if (health == 0)
        {
            Debug.Log("You Died!");
            deathSound.Play();

        }

    }

}
