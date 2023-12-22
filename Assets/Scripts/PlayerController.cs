using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public int maxHealth;
    private int _health;
    private int _points;

    public UnityEvent<int> OnStartGame;
    public UnityEvent<int> OnHealthChange;

    public UnityEvent<int> OnGetPoints;

    public UnityEvent<int> OnGetSlowedBonus;
    public UnityEvent<int> OnGetX2Bonus;

    private void Start()
    {
        _health = maxHealth;
    }

    public void StartGame()
    {
        OnStartGame?.Invoke(maxHealth);
    }

    public void TakeDamage(int value)
    {
        _health -= value;
        OnHealthChange?.Invoke(_health);
    }

    public void GetPoints(int points)
    {
        _points += points;
        OnGetPoints?.Invoke(_points);
    }

    public void GetSlowedBonus(int time)
    {
        OnGetSlowedBonus?.Invoke(time);
    }

    public void GetX2Bonus(int time)
    {
        OnGetX2Bonus?.Invoke(time);
    }
}
