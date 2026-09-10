using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject objectPrefab;
    public float CameraUpSpeed = 3f; 

    public void OnCameraUp(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            ToggleObjects();
            //moveSpeed = CameraUpSpeed;
        }
        if (context.canceled)
        {
            ToggleObjects();
            //moveSpeed = Original Move Speed
        }
    }

    void ToggleObjects()
    {
        bool currentState = objectPrefab.activeSelf;
        objectPrefab.SetActive(!currentState);
    }

}
