using UnityEngine;

public class Interactor : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit " + other.name);
        if (other.TryGetComponent(out IInteract interact))
        {
            interact.Interact();
        }
    }

}
