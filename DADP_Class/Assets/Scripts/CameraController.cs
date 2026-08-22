using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject _object;

    public void OnCameraUp(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            ToggleObjects();
        }
    }

    void ToggleObjects()
    {
        bool currentState = _object.activeSelf;
        _object.SetActive(!currentState);
    }

    /*
     List of things to do (in order of importance)
        1. Make it so that instead of a single object, and entire layer is effected
        2. Add a slight delay to the action
        3. Make player slower while camera is up
        4. Create a UI for the camera coming up and down AND UI for when camera is up
    */
}
