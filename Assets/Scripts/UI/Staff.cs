using UnityEngine;
using System;

public class Staff : MonoBehaviour, IWeapon
{
    public void Attack()
    {
        Debug.Log("Staff Attack");
        ActiveWeapon.Instance.ToggleIsAttacking(false);
    }
}
