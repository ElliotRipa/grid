using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawnerScript : MonoBehaviour
{

    public float moveFrequency = 1.0f;
    private float timer = 0;

    public GameObject cat;

    // Start is called before the first frame update
    void Start()
    {
        
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
            Instantiate(cat, transform.position, Quaternion.identity);
            // Debug.Log(transform.position);
            timer = 0;
        }
        
    }

}
