using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (DoorScript.instance != null)
        {
            DoorScript.instance.collectablesCount++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            Destroy(gameObject);

            if (DoorScript.instance != null)
            {
                DoorScript.instance.DecrementCollectables();
            }
        }
    }
}
