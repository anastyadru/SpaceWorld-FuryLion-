// Copyright (c) 2012-2024 FuryLion Group. All Rights Reserved.

using UnityEngine;

public class BulletControllerEnemy : MonoBehaviour
{
    private float initialSpeed = 100;
    private float speedMultiplier = 1.05f;
    
    private EnemyController enemyController;
    private Rigidbody rb;

    private void Awake()
    {
        enemyController = FindObjectOfType<EnemyController>();
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            player.health -= 5;
            if (player.health <= 0)
            {
                player.OnRelease();
            }
            
            OnHit();
        }
    }
    
    private void OnHit()
    {
        Destroy(gameObject);
    }
    
    private void Update()
    {
        if (enemyController != null)
        {
            float currentSpeed = initialSpeed * Mathf.Pow(speedMultiplier, enemyController.currentWave);
            rb.velocity = new Vector3(0, 0, -currentSpeed);
        }
    }
}