using UnityEngine;

public class CharacterFactory : MonoBehaviour
{
    [SerializeField] private Character[] character;
    [SerializeField] private CharacterDatabase CharacterDatabase;

    void Start()
    {
        SetCharacterStatus();
    }

    public void SetCharacterStatus()
    {
        foreach (var chara in character)
        {
            CharacterData characterData = CharacterDatabase.GetCharacterDataById(chara.CharacterID);

            chara.Initialize(characterData);
        }
    }

}
