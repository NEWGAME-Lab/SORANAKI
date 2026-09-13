using UnityEngine;

public class StageMoveCheck : MonoBehaviour
{
    private void Awake()
    {

    }

    public void MoveToStage()
    {
        if (SceneMove.Instance != null)
        {
            SceneMove.Instance.Move("Stage");
        }
    }
}
