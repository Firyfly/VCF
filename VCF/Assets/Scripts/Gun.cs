using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public float speed = 40;
    public GameObject bullet;
    public Transform barrel;

    public void Fire()
    {
        GameObject spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
        spawnedBullet.GetComponent<Rigidbody>().velocity = speed * barrel.forward;

        Destroy(spawnedBullet, 3);

        GameObject spawnedBullet2 = Instantiate(bullet, barrel.position-new Vector3(0,0,1), barrel.rotation);
        spawnedBullet2.GetComponent<Rigidbody>().velocity = speed * barrel.forward;

        Destroy(spawnedBullet2, 3);

    }


}
