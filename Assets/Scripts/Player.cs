using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    void Update()
    {
        if (Controls.Forward && !Controls.Back)
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }
        else if (Controls.Back && !Controls.Forward)
        {
            transform.position -= transform.forward * Time.deltaTime * speed;
        }

        if (Controls.Left && !Controls.Right)
        {
            transform.eulerAngles -= Vector3.up * Time.deltaTime * turnSpeed;
        }
        else if (Controls.Right && !Controls.Left)
        {
            transform.eulerAngles += Vector3.up * Time.deltaTime * turnSpeed;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col);
        if (col.tag == "Lost")
        {
            Game.Instance.EndGame();
        }
        if (col.tag == "Win")
        {
            Game.Instance.EndGame(true);
        }
    }
}