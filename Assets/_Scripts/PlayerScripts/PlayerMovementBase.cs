using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBase : MonoBehaviour
{
    [Header("References")]
    public PlayerMovementStats MoveStats;
    public InputReader input;
    [SerializeField] private Collider2D bodyColl;
    [SerializeField] private Collider2D feetColl;
    private Rigidbody2D _rb;
     
    //Movement variables
    private Vector2 _moveVelocity;
    private bool _isFacingRight;

    //collision check variables
    private RaycastHit2D _groundHit;
    private RaycastHit2D _headHit;
    private bool _isGrounded;
    private bool _bumpedHead;

    private void Awake()
    {
        _isFacingRight = true;

        _rb = GetComponent<Rigidbody2D>();


    }

    #region Movement
    
    private void Move(float acceleration, float deacceleration,Vector2 moveInput) 
    {
        if(moveInput != Vector2.zero)
        {
            //check if player needs to turn around
            TurnCheck(moveInput);
            
            Vector2 targetVelocity = Vector2.zero;
            targetVelocity = new Vector2(moveInput.x, 0) * MoveStats.maxWalkSpeed;
            
            _moveVelocity = Vector2.Lerp(_moveVelocity, targetVelocity, acceleration * Time.fixedDeltaTime);
            _rb.velocity = new Vector2(_moveVelocity.x,_rb.velocity.y);
        }
        if(moveInput == Vector2.zero)
        {
            _moveVelocity = Vector2.Lerp(_moveVelocity, Vector2.zero, deacceleration * Time.fixedDeltaTime);
            _rb.velocity = new Vector2(_moveVelocity.x, _rb.velocity.y);
        }
    }

    private void TurnCheck(Vector2 moveInput)
    {
        if(_isFacingRight && moveInput.x < 0) 
        {
            Turn(false);
        }
        else if(!_isFacingRight && moveInput.x > 0)
        {
            Turn(true);
        }
    }
    private void Turn(bool turnRight)
    {
        if (turnRight)
        {
            _isFacingRight = true;
            transform.Rotate(0f,180f,0f);
        }
        else
        {
            _isFacingRight = false;
            transform.Rotate(0f, -180f, 0f);
        }
    }

    #endregion

    #region Collision Check
    
}
