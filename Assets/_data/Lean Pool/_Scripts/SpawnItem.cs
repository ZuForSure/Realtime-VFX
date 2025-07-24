using Lean.Pool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public GameObject item;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        LeanPool.Spawn(this.item, transform.position, transform.rotation);
        LeanPool.Despawn(collision.gameObject);
    }
}
