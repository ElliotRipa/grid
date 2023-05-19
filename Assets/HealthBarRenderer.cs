using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarRenderer : MonoBehaviour
{

    public GameObject playerObject;
    PlayerMovement player;
    private int maxHealth;
    private int lastHealth;
    private float barSize;


    // Start is called before the first frame update
    void Start()
    {
        player = playerObject.GetComponent<PlayerMovement>();

        maxHealth = player.health;
        lastHealth = maxHealth;
        barSize = 4;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(player.health);
        if(player.health != lastHealth)
        {
            float barRatio = (float)player.health / (float)maxHealth;
            Debug.Log("health: " + player.health);
            Debug.Log("maxHealth: " + maxHealth);

            Debug.Log("barRatio: " +barRatio);
            float currentBarSize = barRatio * barSize;
            Debug.Log("currentBarSize: " + currentBarSize);

            float barPosition = -1 + (currentBarSize/4);
            Debug.Log("barPosition: " + barPosition);

            transform.localScale = new Vector3(barRatio, 1, 1);

            transform.position = new Vector3(barPosition, 4, -1);
        
        }
    }
}
