using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "InputReader")]
public class InputReader : ScriptableObject, FirstPlayerActionMap.IPlayer1ControlsActions, FirstPlayerActionMap.IPlayer1UIActions
{
    private FirstPlayerActionMap _gameInput;

    private void OnEnable()
    {
        if (_gameInput == null)
        {
            _gameInput = new FirstPlayerActionMap();

            _gameInput.Player1Controls.SetCallbacks(this);
            _gameInput.Player1UI.SetCallbacks(this);

            EnableGameplayInput();

        }
    }

    private void OnDisable()
    {
        DisableAllInput();
    }

    public void EnableGameplayInput()
    {
        _gameInput.Player1Controls.Enable();
        _gameInput.Player1UI.Disable();
    }

    public void EnableUIInput()
    {
        _gameInput.Player1UI.Enable();
        _gameInput.Player1Controls.Disable();
    }

    public event Action<Vector2> MoveEvent;
    public event Action RunPressedEvent;
    public event Action RunCancelledEvent;
    public event Action JumpWasPressedEvent;
    public event Action JumpIsHeldEvent;
    public event Action JumpWasReleasedEvent;

    public event Action PauseEvent;
    public event Action ResumeEvent;

    public void OnMove(InputAction.CallbackContext context)
    {
        //Debug.Log($"Phase.:{context.phase}, Value.:{context.ReadValue<Vector2>()}");
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
    public void OnRun(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            RunPressedEvent?.Invoke();
        }
        if (context.phase == InputActionPhase.Canceled)
        {
            RunCancelledEvent?.Invoke();
        }
    }
    public void OnPause(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            PauseEvent?.Invoke();
            EnableUIInput();
        }
    }

    public void OnResume(InputAction.CallbackContext context)
    {
         if (context.phase == InputActionPhase.Performed)
        {
            ResumeEvent?.Invoke();
            EnableGameplayInput();
        }
    }
    public void DisableAllInput()
    {
        _gameInput.Player1Controls.Disable();
        _gameInput.Player1UI.Disable();
    }
}
