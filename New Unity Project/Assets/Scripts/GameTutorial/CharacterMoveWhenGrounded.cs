using UnityEngine;

[CreateAssetMenu]
public class CharacterMoveWhenGrounded : CharacterBaseNew, IMove
{

    public override void Move(CharacterController controller)
    {
        if (Controller.isGrounded)
        {
            location.x = Input.GetAxis("Horizontal") * moveSpeed;
        }
        
        location.y += gravity * Time.deltaTime;
        Controller.Move(location * Time.deltaTime);
    }
}
