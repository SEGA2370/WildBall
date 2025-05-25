using UnityEngine;
using WildBall.Inputs;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerController : MonoBehaviour
{
    private PlayerMovement mover;
    private MobileInputManager mobileInput;

    void Awake()
    {
        mover = GetComponent<PlayerMovement>();
        mobileInput = FindObjectOfType<MobileInputManager>();
    }

    void FixedUpdate()
    {
        Vector3 moveVec;

        if (Application.isMobilePlatform && mobileInput != null)
        {
            float h = mobileInput.Horizontal;

            // Choose +1 for forward, –1 for backward, 0 if neither or both
            float v = 0f;
            if (mobileInput.Forward && !mobileInput.Backward) v = 1f;
            else if (mobileInput.Backward && !mobileInput.Forward) v = -1f;

            moveVec = new Vector3(-h, 0, -v).normalized;
            mover.MoveCharacter(moveVec);

            if (mobileInput.JumpPressed)
                mover.Jump();
            mobileInput.ResetJump();
        }
        else
        {
            // Desktop/WebGL: existing axes + space jump
            float h = Input.GetAxis(GlobalStringVariable.HORIZONTAL_AXIS);
            float v = Input.GetAxis(GlobalStringVariable.VERTICAL_AXIS);
            moveVec = new Vector3(-h, 0, -v).normalized;

            mover.MoveCharacter(moveVec);

            if (Input.GetButtonDown(GlobalStringVariable.JUMP_BUTTON))
                mover.Jump();
        }
    }
}
