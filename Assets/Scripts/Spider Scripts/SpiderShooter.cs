using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderShooter : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Attack());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Attack()
    {
        // in 2 to 7 sec spider gonna attack
        yield return new WaitForSeconds(Random.Range(2, 7));
        // set position of bullet as same as spider
        Instantiate(bullet, transform.position, Quaternion.identity);
        StartCoroutine(Attack());
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            Destroy(target.gameObject);
        }
    }
}
