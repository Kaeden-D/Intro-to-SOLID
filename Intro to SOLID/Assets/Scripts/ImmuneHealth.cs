using System;
using UnityEngine;

public class ImmuneHealth : MonoBehaviour, IHealth
{
    [SerializeField] private int aliveOrDead = 1;

    public event Action<float> OnHPPctChanged = delegate { };
    public event Action OnDied = delegate { };

    private void Start()
    {
        aliveOrDead = 1;
    }

    public float CurrentHpPct
    {
        get { return (float) aliveOrDead; }
    }

    public void TakeDamage(int amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException("Invalid Damage amount specified: " + amount);

        OnHPPctChanged(CurrentHpPct);

        if (CurrentHpPct <= 0)
            Die();

        Debug.Log("ImmuneHealth: TakeDamage called, but this entity is immune to damage.");
    }

    private void Die()
    {
        OnDied();
        GameObject.Destroy(this.gameObject);
    }
}