using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoGaunlet : MonoBehaviour
{
    public float speed;
    private Transform transformPlayer; 
    void Start()
    {
        transformPlayer = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.LookAt(transformPlayer);
    }
}
