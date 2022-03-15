using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, FPS_Controller
{
    private int damage = 3;
    public void Damage()
    {
        damage--;
    }

    public void Attack()
    {
        if (damage == 0)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(damage);
        Attack();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            Destroy(collision.gameObject);
            Damage();
        }
    }

    public void Shoot()
    {
        throw new System.NotImplementedException();
    }
}
