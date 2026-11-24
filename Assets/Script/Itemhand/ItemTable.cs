using UnityEngine;

/// <summary>
/// アイテムの一覧アセット。Project右クリック > Create > Tables > ItemTable で作成。
/// </summary>
[CreateAssetMenu(fileName = "ItemTable", menuName = "Tables/ItemTable")]
public class ItemTable : TableAsset<ItemData> { }
