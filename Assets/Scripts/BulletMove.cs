using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    float speed = 100;
  
    void Start()
    {
        
    }

    
    void LateUpdate()
    {

        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
