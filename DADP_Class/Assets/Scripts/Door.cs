using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator DoorAnimator;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            bool isOpen = DoorAnimator.GetBool("isOpen");

            if (isOpen)
            {
                DoorAnimator.SetTrigger("CloseDoor");
                DoorAnimator.SetBool("isOpen", false);
            }
            else
            {
                DoorAnimator.SetTrigger("OpenDoor");
                DoorAnimator.SetBool("isOpen", true);
            }
        }
    }
}