using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private RaycastHit hit;
    public GameObject bullet;
    public GameObject barrel;
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           GameObject instaBullet= Instantiate(bullet, barrel.transform.position, barrel.transform.rotation);
            instaBullet.GetComponent<Rigidbody>().AddForce(Vector3.back * 500);
            Destroy(instaBullet, 10f);
        }
    }
}
