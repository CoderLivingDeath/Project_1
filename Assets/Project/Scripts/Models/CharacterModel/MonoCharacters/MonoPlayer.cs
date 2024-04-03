using System;
using Project.Scripts.Models.MovementWithStatsModel;
using Project.Scripts.Configs;
using Project.Scripts.Core.Interfaces;
using Project.Scripts.Models.CharacterModel;
using Project.Scripts.Models.CharacterStatistic;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

[RequireComponent(typeof(Rigidbody2D))]
public sealed class MonoPlayer : MonoBehaviour, IMovableWithStats, IDisposable
{
    private Player _player;
    public Player Player => _player;

    public Stats BaseStats => _player.BaseStats;

    public Stats ActualStats => _player.ActualStats;

    public SecondStats BaseSecondStats => _player.BaseSecondStats;

    public SecondStats ActualSecondStats => _player.ActualSecondStats;

    public Vector2 MoveVector { get; private set; }

    public GameObject GameObject => this.gameObject;

    private MovementHandlerWithStats _movementHandler;

    private InputActions _inputActions;

    [SerializeField] private Rigidbody2D _rigidbody;

    [Inject]
    public void Constructor(InputActions inputActions /*Player player*/)
    {
        _inputActions = inputActions;
        inputActions.Gameplay.Movement.performed += OnPerformed;
        inputActions.Gameplay.Movement.canceled += OnCanceled;
    }

    private void Start()
    {
        _movementHandler = new();

        Stats baseStats = new();
        SecondStats secondStats = new();

        PlayerConfig config = new PlayerConfig(baseStats, secondStats);

        _player = new Player(config);

        _movementHandler.OnMoveEvent += (x) => Debug.Log(x.movementData.MovableObject.GetType().ToString() + $" : MovementVecotr({x.movementData.Direction})" +  $" : Position({x.movementData.MovableObject.GameObject.transform.position}" + $" : PrevPosition({x.PreviousPosition}");
    }

    private void FixedUpdate()
    {
        if(MoveVector != Vector2.zero)
        {
            Move(MoveVector);
        }
    }

    public void Move(Vector2 direction)
    {
        MovementWithStatsData data = new MovementWithStatsData(this, direction, _rigidbody);
        _movementHandler.Move(data);
    }

    public void Dispose()
    {
        _inputActions.Gameplay.Movement.performed -= OnPerformed;
        _inputActions.Gameplay.Movement.canceled -= OnCanceled;

        _player = null;
    }

    private void OnPerformed(InputAction.CallbackContext context)
    {
        MoveVector = context.ReadValue<Vector2>();
    }

    private void OnCanceled(InputAction.CallbackContext context)
    {
        MoveVector = context.ReadValue<Vector2>();
    }
}
