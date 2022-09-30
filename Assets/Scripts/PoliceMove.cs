using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceMove : MonoBehaviour
{
    public GameObject target;
    float speed = 10f;

    void Start()
    {
        
    }

    
    void LateUpdate()
    {
        Vector3 direction = (target.transform.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 2);



        if (Vector3.Angle(direction, transform.forward) < 20 && Vector3.Angle(direction, transform.forward) > 10)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        
    }
}
