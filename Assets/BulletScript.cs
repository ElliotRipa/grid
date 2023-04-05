using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public float moveSpeed;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("HeartPlayer");
        Debug.Log("Player found at " + player.name);

        transform.transform.LookAt(player.transform.position);

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
        Debug.Log(transform.position);
    }
}
