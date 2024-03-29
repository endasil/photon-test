using Fusion;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : NetworkBehaviour
{
    private CharacterController _controller;

    public float PlayerSpeed = 2f;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }
    
    public override void FixedUpdateNetwork()
    {
        if(HasStateAuthority == false)
        {
            return;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * Runner.DeltaTime;
    
        if(move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

    }



   
}
