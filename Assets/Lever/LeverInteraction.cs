using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LeverInteraction : MonoBehaviour
{
    private Animator animator;
    // private bool isTurnedOn = false;
    public ontroller mainBox;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // This method should be called when the lever is grabbed and pulled
    public void Interact()
    {
        animator.SetBool("TurnedOn", true); // Update the animator parameter
        mainBox.setLever();
    }

    // Optional: Call Interact method when lever is grabbed
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand")) // Assuming the player's hand is tagged as "PlayerHand"
        {
            Interact();
            mainBox.setLever();
        }
    }
}
