using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Character
{
    private PlayerMove playerMove;
    private PlayerDamageCalculator damageCalculator;
    [SerializeField] private float moveSpeed = 5.0f;
    //public int CharacterID { get; protected set; } = 1;

    private void Awake()
    {
        CharacterID = 1;
        playerMove = new PlayerMove(moveSpeed);
        damageCalculator = new PlayerDamageCalculator();
    }
    
    private void Update()
    {
        // 毎フレームの処理
        transform.Translate(Vector3.forward * Time.deltaTime);

        if (Keyboard.current.wKey.isPressed)
        {
            // 上方向へのy = 1;
            transform.position = playerMove.Up(transform.position, Time.deltaTime);
        }

        if (Keyboard.current.sKey.isPressed)
        {
            ///y = -1;
            transform.position = playerMove.Down(transform.position, Time.deltaTime);
        }

        if (Keyboard.current.aKey.isPressed)
        {
            //x = -1;
            transform.position = playerMove.Left(transform.position, Time.deltaTime);
        }

        if (Keyboard.current.dKey.isPressed)
        {
            //x = 1;
            transform.position = playerMove.Right(transform.position, Time.deltaTime);
        }
    }


}
