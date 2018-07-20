using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_translation : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += 5.0f * transform.forward * Time.deltaTime;
        transform.Rotate(0.0f, Input.GetAxis("Horizontal"), 0.0f);

        Vector3 moveCamTo = transform.position - transform.forward * 10.0f + Vector3.up * 2.0f;
        float bias = 0.5f;
        Camera.main.transform.position = Camera.main.transform.position * bias + moveCamTo * (1 - bias);
        Camera.main.transform.LookAt(transform.position + transform.forward * 30.0f);
    }
}
