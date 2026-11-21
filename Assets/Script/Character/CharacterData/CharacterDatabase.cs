using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "CharacterDatabase", menuName = "ScriptableObjects/CharacterDatabase", order = 1)]
public class CharacterDatabase : ScriptableObject
{
   [SerializeField] private List<CharacterData> characterData = new List<CharacterData>();

    public CharacterData GetCharacterDataById(int id)
    {
        return characterData.Find(data => data.id == id);
    }
}
