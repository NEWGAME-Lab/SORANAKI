using UnityEngine;

public class Interactor : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IInteract interact))
        {
            interact.Interact();
        }
    }

}
