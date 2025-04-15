using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "Player1InputReader")]
public class FirstPlayerInputReaderScript : ScriptableObject, FirstPlayerActionMap.IPlayer1ControlsActions, FirstPlayerActionMap.IPlayer1UIActions
{
    private FirstPlayerActionMap _playerInput;

    private void OnEnable()
    {
        if(_playerInput == null)
        {
            _playerInput = new FirstPlayerActionMap();

            _playerInput.Player1Controls.SetCallbacks(this);
            _playerInput.Player1UI.SetCallbacks(this);
        }
    }

    private void OnDisable()
    {
        DisableAllInput();
    }

    public void DisableAllInput()
    {
        _playerInput.Player1Controls.Disable();
        _playerInput.Player1UI.Disable();
    }

    public void EnablePlayerInput()
    {
        _playerInput.Player1Controls.Enable();
        _playerInput.Player1UI.Disable();
    }
    public void EnableUIInput()
    {
        _playerInput.Player1Controls.Disable();
        _playerInput.Player1UI.Enable();
    }

    //Gameplay Events
    public event Action<Vector2> MoveEvent;
    public event Action JumpWasPressedEvent;
    public event Action JumpIsHeldEvent;
    public event Action JumpWasReleasedEvent;
    //UI events
    public event Action PauseEvent;
    public event Action ResumeEvent;

    public void OnMove(InputAction.CallbackContext context)
    {
        MoveEvent?.Invoke(context.ReadValue<Vector2>());
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            JumpWasPressedEvent?.Invoke();
        }
        if (context.phase == InputActionPhase.Performed)
        {
            JumpIsHeldEvent?.Invoke();
        }
        if (context.phase == InputActionPhase.Canceled)
        {
            JumpWasReleasedEvent?.Invoke();
        }
    }

    public void OnResume(InputAction.CallbackContext context)
    {
        throw new NotImplementedException();
    }

    public void OnPause(InputAction.CallbackContext context)
    {
        throw new NotImplementedException();
    }
}
