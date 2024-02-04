using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectile;
    public GameObject gunner;
    public Transform point;
    public int speed;


    private int count=0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && count < 2)
        {
            gunner.GetComponent<Animator>().Play("GunnerShoot");
            GameObject bul = (GameObject)Instantiate(projectile, point.transform.position, Quaternion.identity);
            bul.gameObject.GetComponent<Rigidbody>().velocity = Camera.main.transform.right * speed;
          
            count++;
        }
        else if (Input.GetMouseButtonDown(0) && count == 2)
        {
            gunner.GetComponent<Animator>().Play("GunnerShoot");
            GameObject bul = (GameObject)Instantiate(projectile, point.transform.position, Quaternion.identity);
            bul.gameObject.GetComponent<Collision>().setBlastRadius(2.5f);
            bul.gameObject.GetComponent<Collision>().setExplosionPower(300);
            bul.gameObject.GetComponent<Rigidbody>().velocity = Camera.main.transform.right * speed;
            count++;
        }
        else
        {
            //play empty clicking sound
        }

    }
}

