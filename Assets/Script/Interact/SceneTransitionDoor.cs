using UnityEngine;

public class SceneTransitionDoor : MonoBehaviour,IInteract
{
    [SerializeField] private StageMoveCheck stageMoveCheck;
    //[SeSceneMove sceneMove;
    private void Awake()
    {
        //sceneMove = GameObject.FindAnyObjectByType<SceneMove>();
        //Debug.Assert(sceneMove != null, "SceneMove is null");

    }
    /// <summary>
    /// Interacterが飛び出す関数
    /// </summary>
     void IInteract.Interact()
    {
        Debug.Log("SceneTransitionDoor Interact");

        stageMoveCheck.MoveToStage();//後でチェック側に移す

    }
}
