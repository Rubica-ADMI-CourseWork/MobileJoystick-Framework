using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthSystem : MonoBehaviour
{
    [SerializeField] float maxhealth;
    [SerializeField] GameObject destructionFX;

    public void TakeDamage(float damageAmnt)
    {
        Debug.Log("Inside Take Damage");
        maxhealth-=damageAmnt;
        if(maxhealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        var fx = Instantiate(destructionFX,transform.position,Quaternion.identity);
        Destroy(gameObject);
        Destroy(fx, .3f); 
    }
}
