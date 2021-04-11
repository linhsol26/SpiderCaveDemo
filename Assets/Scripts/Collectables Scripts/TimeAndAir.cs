using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeAndAir : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            if (gameObject.name == "Air")
            {
                GameObject.Find("GamePlay Controller").GetComponent<AirController>().air += 15f;
            } else
            {
                GameObject.Find("GamePlay Controller").GetComponent<TimeController>().time += 15f;
            }
            Destroy(gameObject);
        }
    }
}
