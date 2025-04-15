using System;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "Player2InputReader")]
public class SecondPlayerInputReaderScript : ScriptableObject, SecondPlayerActionMap.IPlayer2ControlsActions, SecondPlayerActionMap.IPlayer2UIActions
{
    private SecondPlayerActionMap _secondPlayerInput;

    private void OnEnable()
    {
        if (_secondPlayerInput == null)
        {
            _secondPlayerInput = new SecondPlayerActionMap();

            _secondPlayerInput.Player2Controls.SetCallbacks(this);
            _secondPlayerInput.Player2UI.SetCallbacks(this);
        }
    }

    private void OnDisable()
    {
        DisableAllInput();
    }

    public void DisableAllInput()
    {
        _secondPlayerInput.Player2Controls.Disable();
        _secondPlayerInput.Player2UI.Disable();
    }

    public void EnablePlayerInput()
    {
        _secondPlayerInput.Player2Controls.Enable();
        _secondPlayerInput.Player2UI.Disable();
    }
    public void EnableUIInput()
    {
        _secondPlayerInput.Player2Controls.Disable();
        _secondPlayerInput.Player2UI.Enable();
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
