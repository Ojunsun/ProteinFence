using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour, IDamageable
{
    public UnityEvent OnHitTriggered = null;
    public UnityEvent OnDeadTriggered = null;

    private int _currentHP;
    public int MaxHP;


    public void OnDamage(int damage, Vector3 point, Vector3 normal)
    {
        OnHitTriggered?.Invoke();

        if(_currentHP <= 0)
        {
            OnDeadTriggered?.Invoke();
        }
    }
}
