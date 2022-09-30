using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bulletSpawnPos;
    public GameObject target;
    public GameObject parent;
    float speed = 15;
    bool canShoot = true;

    void Start()
    {
        
    }

    void CanShootAgain()
    {
        canShoot = true;
    }

    void Fire()
    {
        if (canShoot)
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPos.transform.position, bulletSpawnPos.transform.rotation);
            canShoot = false;
            Invoke("CanShootAgain", 1.5f);
        }
       
    }
    
    void Update()
    {
        Vector3 direction = (target.transform.position - parent.transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        parent.transform.rotation = Quaternion.Slerp(parent.transform.rotation, lookRotation, Time.deltaTime * 2);

       
            
        if (Vector3.Angle(direction,parent.transform.forward) < 10)
        {
            Fire();
        }
        

        
    }

    


}
