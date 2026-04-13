using System;
using UnityEngine;

public class TickSystem : MonoBehaviour {
    public static TickSystem Instance { get; private set; }

    public event EventHandler<int> OnTick;
    
    [SerializeField] private float tickInterval = .5f;

    private int _tick = 0;
    public int CurrentTickNum => _tick;

    private float _tickTimer = 0f;

    private void Awake() {
        if (Instance != null) {
            Debug.Log("Can't have multiple instances of TickSystem!");
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
    }

    private void Update() {
        _tickTimer -= Time.deltaTime;

        if (_tickTimer > 0)
            return;

        Tick();
        _tickTimer = tickInterval;
    }

    private void Tick() {
        _tick++;
        OnTick?.Invoke(this, _tick);
    }

}