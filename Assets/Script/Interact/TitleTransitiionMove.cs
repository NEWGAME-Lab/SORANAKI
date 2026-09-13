using UnityEngine;

public class TitleTransitiionMove : MonoBehaviour, IInteract
{
    private void Awake()
    {

    }

    [SerializeField]
    private TitleMoveCheck TitleMoveCheck;

    /// <summary>
    /// Interacterが飛び出す関数
    /// </summary>

    void IInteract.Interact()
    {
        Debug.Log("SceneTransitionDoorInteract");

        TitleMoveCheck.MoveToTitle();
    }
}