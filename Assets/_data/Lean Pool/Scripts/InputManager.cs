using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : ZuSingleton<InputManager>
{
    [SerializeField] protected bool shootInput = false;
    public bool ShootInput => shootInput;

    private void Update()
    {
        this.GetShootInput();
    }

    protected virtual void GetShootInput()
    {
        this.shootInput = Input.GetKeyDown(KeyCode.Space);
        if(this.shootInput) Debug.Log("Shoot");
    }
}
