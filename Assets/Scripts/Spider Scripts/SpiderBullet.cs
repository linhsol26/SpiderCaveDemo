using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            GameObject.Find("GamePlay Controller").GetComponent<GamePlayController>().PlayerDied();
            Destroy(target.gameObject);
            Destroy(gameObject);
        }

        if (target.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
