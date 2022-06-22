using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellBehaviour : MonoBehaviour //shell data to be scriptable object
{
    public float timeToDestruction;
    public float timeToVfxDestruction;
    public GameObject shellVFX;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            HandleShellDestruction();
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealthSystem>().TakeDamage(10f);
        }
    }

    private void HandleShellDestruction()
    {
        var shellFX = Instantiate(shellVFX);
        Destroy(gameObject, timeToDestruction);
        Destroy(shellFX,timeToVfxDestruction);
    }
}
