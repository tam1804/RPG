using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamageable
{
    [Header("Config")]
    [SerializeField] private PlayerStats stats;

    private PlayerAnimations playerAnimations;

    private void Awake()
    {
        playerAnimations = GetComponent<PlayerAnimations>();
    }

    public void TakeDame(float amount)
    {
        stats.Health -= amount;
        if(stats.Health < 0f) 
        { 
        PlayerDead();
        }
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)) {
            TakeDame(1f);
        }
    }
    private void PlayerDead()
    {
        playerAnimations.SetDeadAnimation();
    }
}
