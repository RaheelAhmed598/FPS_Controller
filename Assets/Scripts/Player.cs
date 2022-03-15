using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour,FPS_Controller
{
    private float speed = 5;
    private Rigidbody playerRb;
    public GameObject bullet;
    public void Damage()
    {
        throw new System.NotImplementedException();
    }

    public void Shoot()
    {
        Instantiate(bullet, transform.position + new Vector3(0, 0, 1), bullet.transform.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    public void Attack()
    {
        throw new System.NotImplementedException();
    }
}
