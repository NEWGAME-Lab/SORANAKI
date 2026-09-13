using UnityEngine;

public class StageTownTransitiionMove : MonoBehaviour, IInteract
{
    private void Awake()
    {

    }

    [SerializeField]
    private StageTownMoveCheck stageTownMoveCheck;

    ///<summary>
    /// Interacterが飛び出す関数
    /// </summary>
    
    void IInteract.Interact()
    {
        Debug.Log("SceneTransitionDoorInteract");

        stageTownMoveCheck.MoveToStageTown();
    }
}
