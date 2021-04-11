using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    private Slider slider;
    private GameObject player;

    public float time = 100f;
    public float timeBurn = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
        GetPreferences();
    }

    // Update is called once per frame
    void Update()
    {
        if (!player) return;

        if (time > 0)
        {
            time -= timeBurn * Time.deltaTime;
            slider.value = time;
        }
        else
        {
            GetComponent<GamePlayController>().PlayerDied();
            Destroy(player);
        }
    }

    void GetPreferences()
    {
        player = GameObject.Find("Player");
        slider = GameObject.Find("Time Slider").GetComponent<Slider>();

        slider.minValue = 0f;
        slider.maxValue = time;
        slider.value = slider.maxValue;
    }
}
