// Copyright (c) 2012-2024 FuryLion Group. All Rights Reserved.

using UnityEngine;

public class BulletControllerPlayer : MonoBehaviour
{
    public float speed = 100;
    
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Enemy enemy = other.GetComponent<Enemy>();
            enemy.TakeDamage(20);
            
            OnHit();
        }
    }
    
    public void OnHit()
    {
        Destroy(gameObject);
    }
    
    private void Update()
    {
        rb.velocity = new Vector3(0, 0, speed);
    }
}