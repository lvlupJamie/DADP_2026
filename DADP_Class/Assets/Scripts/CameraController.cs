using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject objectPrefab;

    public void OnCameraUp(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            ToggleObjects();
            //moveSpeed = 3f;
        }
    }

    void ToggleObjects()
    {
        bool currentState = objectPrefab.activeSelf;
        objectPrefab.SetActive(!currentState);
    }

    /*
     List of things to do (in order of importance)
        (DONE)  1. Make it so that instead of a single object, and entire layer is effected
        (DONE)  2. Add UI indication that camera is up
                3. Add a slight delay to the action
        (DONE)  4. Make player slower while camera is up
                5. Create a UI for the camera coming up and down
    */
}
