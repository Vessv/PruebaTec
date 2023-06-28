using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FPSCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDelta(InputAction.CallbackContext context)
    {
        Debug.Log("test");
        Vector2 mouseDelta = context.ReadValue<Vector2>();
    }

    public void Test(InputAction.CallbackContext context)
    {
        Debug.Log("test");

    }

}
