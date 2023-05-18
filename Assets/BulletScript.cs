using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BulletScript : MonoBehaviour
{

    public float moveSpeed = 8;

    private GameObject player;

    private Vector3 vectorToPlayer;

    public float lowerX = -12F;
    public float upperX = 12F;
    public float lowerY = -6F;
    public float upperY = 6F;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("HeartPlayer");
        Debug.Log("Player found at " + player.name);

        Quaternion angle = AngleToPlayer(player);
        Debug.Log(angle);

        transform.transform.rotation = angle;

        vectorToPlayer = VectorToPlayer(player);

        /*
        Vector2 playerDirectionVector = transform.position - player.transform.position;
        Debug.Log(playerDirectionVector);
        playerDirectionVector.Normalize();
        Debug.Log(playerDirectionVector);

        //Quaternion playerDirectionQuaternion = Quaternion.FromToRotation(transform.rotation.eulerAngles.normalized, playerDirectionVector);
        Quaternion playerDirectionQuaternion = Quaternion.LookRotation(playerDirectionVector);

        Debug.Log("Rotation calculated to " + playerDirectionQuaternion);
        transform.rotation = playerDirectionQuaternion;
        Debug.Log(transform.position);*/
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += transform.forward * moveSpeed * Time.deltaTime ;
        //Debug.Log(transform.position);

        if (OutOfBounds())
        {
            Destroy(gameObject);

        }

        float xSpeed = Mathf.Sin(transform.rotation.z);

        transform.position += vectorToPlayer * Time.deltaTime * moveSpeed;

    }

    Quaternion AngleToPlayer(GameObject player)
    {
        double a = transform.position.y - player.transform.position.y;
        double b = transform.position.x - player.transform.position.x;

        double aOverB = a / b;

        float angle = Mathf.Atan((float)aOverB);

        angle *= Mathf.Rad2Deg;

        Quaternion q;

        if(b < 0)
        {
            q = Quaternion.Euler(0, 0, angle);
        } 
        else
        {
            q = Quaternion.Euler(0, 0, 180 + angle);
        }

        
        return q;

    }

    Vector3 VectorToPlayer(GameObject player)
    {
        double y = transform.position.y - player.transform.position.y;
        double x = transform.position.x - player.transform.position.x;

        Vector3 vector = new Vector3((float)-x, (float)-y);

        vector.Normalize();

        return vector;

    }

    bool OutOfBounds()
    {
        return (transform.position.x < lowerX || transform.position.x > upperX || transform.position.y < lowerY || transform.position.y > upperY);
    }

}
