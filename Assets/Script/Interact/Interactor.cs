using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class Interactor : MonoBehaviour
{
    // [SerializeField] private DialogueUIController dialogueUIController;
    private bool isPlayerInRange = false;
    private bool keypush = false;
    private string textdata = "-";
    public event Action<string> talk;
    public event Action onHideDialogue;
    private void Update()
    {
        //Keycodeがバージョンが嚙み合わないとかで使えなかったよ～(´;ω;｀)
        if (isPlayerInRange && Keyboard.current != null && Keyboard.current.eKey.wasPressedThisFrame)
        {
            // ShowDialogue();
            talk?.Invoke(textdata);
        }
    }
    // private void ShowDialogue()
    // {
    //     if (dialogueUIController != null)
    //     {
    //         dialogueUIController.ShowDialogue(textdata);
    //     }
    // }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit " + other.name);
        if (other.TryGetComponent(out IInteract interact))
        {
            interact.Interact();
        }
        if (other.TryGetComponent(out ITalkable talkable))
        {
            textdata = talkable.GetInteract();
            isPlayerInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<ITalkable>() != null)
        {
            isPlayerInRange = false;

            onHideDialogue?.Invoke();
        }
    }
}
