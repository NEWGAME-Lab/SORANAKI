using UnityEngine;

public class GroundEnemy : Enemy
{
    private void Awake()
    {
        base.Awake();
        CharacterID = 2;
    }
}
