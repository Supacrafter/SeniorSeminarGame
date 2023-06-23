using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[DefaultExecutionOrder(-1)]
public class InputReader : MonoBehaviour
{
    public static MainControls controls;

    //public delegate void LeftMouseClick(Vector2 mousePos);
    //public static event LeftMouseClick OnLeftMouseClickStart;
    //public static event LeftMouseClick OnLeftMouseClickPerformed;

    //public delegate void EscapeKeyPressed();
    //public static event EscapeKeyPressed OnEscapeKeyDown;

    //public delegate void TKeyPressed();
    //public static event TKeyPressed OnTKeyDown;

    private void Awake()
    {
        controls = new MainControls();
        ToggleActionMap(controls.Base);
    }

    //private void OnEnable()
    //{
    //    controls.Base.Select.started += ctx => LeftClickStarted(ctx);
    //    controls.Base.Pause.performed += ctx => EscapeKeyDown(ctx);
    //    controls.Base.ToggleMode.performed += ctx => TKeyDown(ctx);

    //    controls.Placement.PlaceTower.started += ctx => LeftClickStarted(ctx);
    //    controls.Placement.Cancel.performed += ctx => EscapeKeyDown(ctx);
    //    controls.Placement.ToggleMode.performed += ctx => TKeyDown(ctx);
    //}

    //private void OnDisable()
    //{
    //    controls.Base.Select.performed -= ctx => LeftClickPerformed(ctx);
    //    controls.Base.Pause.performed -= ctx => EscapeKeyDown(ctx);
    //    controls.Base.ToggleMode.performed -= ctx => TKeyDown(ctx);

    //    controls.Placement.PlaceTower.started -= ctx => LeftClickStarted(ctx);
    //    controls.Placement.Cancel.performed -= ctx => EscapeKeyDown(ctx);
    //    controls.Placement.ToggleMode.performed -= ctx => TKeyDown(ctx);

    //    controls.Disable();
    //}
    //}

    //private void LeftClickStarted(InputAction.CallbackContext ctx)
    //{
    //    OnLeftMouseClickStart?.Invoke(Mouse.current.position.ReadValue());
    //}

    //private void LeftClickPerformed(InputAction.CallbackContext ctx)
    //{
    //    OnLeftMouseClickPerformed?.Invoke(Mouse.current.position.ReadValue());
    //}

    //private void EscapeKeyDown(InputAction.CallbackContext ctx)
    //{
    //    OnEscapeKeyDown?.Invoke();
    //}

    //private void TKeyDown(InputAction.CallbackContext ctx)
    //{
    //    OnTKeyDown?.Invoke();
    //}

    public static void ToggleActionMap(InputActionMap actionMap)
    {
        if (actionMap.enabled)
        {
            return;
        } else
        {
            controls.Disable();
            actionMap.Enable();
        }
    }
}
