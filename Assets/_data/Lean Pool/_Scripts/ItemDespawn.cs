using Lean.Pool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDespawn : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;
        LeanPool.Despawn(this);
    }
}
