using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBase : MonoBehaviour
{
    [Header("References")]
    public PlayerMovementStats MoveStats;
    //public InputReader input;
    [SerializeField] private Collider2D bodyColl;
    [SerializeField] private Collider2D feetColl;
    private Rigidbody2D _rb;
     
    void Update()
    {
        
    }
}
