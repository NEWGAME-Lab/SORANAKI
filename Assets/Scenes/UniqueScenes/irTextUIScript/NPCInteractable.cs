using UnityEngine;

public class NPCInteractable : MonoBehaviour, ITalkable
{
    [SerializeField] private string npcName;
    [TextArea(3, 5)]
    [SerializeField] private string dialogueData;

    public string GetInteract()
    {
        return $"{npcName}: {dialogueData}";
    }
}