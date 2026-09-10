using UnityEngine;

public class StartTownMoveCheck : MonoBehaviour
{

    private void Awake()
    {
        
    }

    public void MoveToStartTown()
    {
        if(SceneMove.Instance != null)
        {
            SceneMove.Instance.Move("StartTown");
        }
    }
}
