using UnityEngine;

public class TitleMoveCheck : MonoBehaviour
{
    private void Awake()
    {

    }

    public void MoveToTitle()
    {
        if (SceneMove.Instance != null)
        {
            SceneMove.Instance.Move("Title");
        }
    }
}
