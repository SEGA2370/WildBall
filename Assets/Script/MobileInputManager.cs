using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileInputManager : MonoBehaviour
{
    [Range(0, 5)] public float tiltSensitivity = 1.3f;

    [HideInInspector] public float Horizontal;
    [HideInInspector] public bool Forward;
    [HideInInspector] public bool Backward;       
    [HideInInspector] public bool JumpPressed;
    [HideInInspector] public bool InteractPressed;

    void Update()
    {
        if (!Application.isMobilePlatform) return;

        // Read device tilt for steering:
        Horizontal = Mathf.Clamp(Input.acceleration.x * tiltSensitivity, -1f, 1f);
    }

    // UI Button callbacks:
    public void OnForwardDown() => Forward = true;
    public void OnForwardUp() => Forward = false;

    public void OnBackwardDown() => Backward = true;   // ← new
    public void OnBackwardUp() => Backward = false;  // ← new

    public void OnJump() => JumpPressed = true;
    public void OnInteract() => InteractPressed = true;

    public void ResetJump() => JumpPressed = false;
    public void ResetInteract() => InteractPressed = false;
}
