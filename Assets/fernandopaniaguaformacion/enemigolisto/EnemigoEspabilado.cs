using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoEspabilado : MonoBehaviour
{
    public float speed;
    public float minAngle;
    public float maxAngle;

    
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);        
    }
    void OnCollisionEnter(Collision c){
        transform.Rotate(0, Random.Range(minAngle, maxAngle), 0);
    }
}
