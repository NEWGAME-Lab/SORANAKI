using UnityEngine;

public class SceneTransitionDoor : MonoBehaviour,IInteract
{
    SceneMove sceneMove;
    private void Awake()
    {
        sceneMove = GameObject.FindAnyObjectByType<SceneMove>();

    }
    void IInteract.Interact()
    {
        Debug.Log("SceneTransitionDoor Interact");
        sceneMove.Move("Title");//後でチェック側に移す

    }
}
