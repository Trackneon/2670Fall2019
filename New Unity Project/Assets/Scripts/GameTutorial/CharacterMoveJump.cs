using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterMoveJump : CharacterBaseNew, IMove
{

    public override void Move()
    {
        if (Input.GetButton("Jump"))
        {
            Jump();
            base.Move();
            location.y = jumpSpeed;
        }

        
    }


}
