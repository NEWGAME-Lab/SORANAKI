using UnityEngine;
using TMPro;

public class DialogueUIController : MonoBehaviour
{
    [SerializeField] private Interactor interactor;
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;

    private void Start()
    {
        interactor.talk+=ShowDialogue;
        interactor.onHideDialogue += HideDialogue;
        HideDialogue();
    }

    //ダイアログ表示
    public void ShowDialogue(string text)
    {
        if (dialoguePanel != null) dialoguePanel.SetActive(true);
        if (dialogueText != null) dialogueText.text = text;
    }

    //ダイアログ非表示
    public void HideDialogue()
    {
        if (dialoguePanel != null) dialoguePanel.SetActive(false);
    }
}