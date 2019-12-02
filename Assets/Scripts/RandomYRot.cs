using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomYRot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = new Vector3(-90, Random.value * 360, 0);
    }
}
