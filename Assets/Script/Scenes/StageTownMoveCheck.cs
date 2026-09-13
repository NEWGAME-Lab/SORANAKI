using UnityEngine;

public class StageTownMoveCheck : MonoBehaviour
{
    private void Awake()
    {

    }

    public void MoveToStageTown()
    {
        if (SceneMove.Instance != null)
        {
            SceneMove.Instance.Move("StageTown");
        }
    }
}
