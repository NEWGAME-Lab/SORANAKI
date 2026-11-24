using UnityEngine;

public class AirEnemy : Enemy
{
    private void Awake()
    {
        base.Awake();
        CharacterID = 2;
    }

}
