using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{
    Light light;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        light.intensity = 10f + Mathf.Sin(Time.time) + Mathf.Sin(Time.time * 17) / 3 + Mathf.Sin(Time.time * 13) / 5;
    }
}
