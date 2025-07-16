using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFX : MonoBehaviour
{
    [SerializeField] protected GameObject thunderAnim;

    public virtual void ClickBTn()
    {
        this.thunderAnim.SetActive(true);
        StartCoroutine(this.TurnOff());
    }

    protected IEnumerator TurnOff()
    {
        yield return new WaitForSeconds(1f);
        this.thunderAnim.SetActive(false);
    }
}
