using UnityEngine;

/// <summary>
/// 動作確認用。空のGameObjectに付けて再生するとConsoleに結果が出る。
/// itemTable が未設定ならサンプルデータで確認する。
/// </summary>
public class ItemHandTest : MonoBehaviour
{
    [SerializeField] private ItemTable itemTable;

    private void Start() => Run();

    [ContextMenu("Run Test")]
    private void Run()
    {
        if (itemTable != null)
            ItemHandSliceCheck.Run(itemTable.Entries);
        else
            ItemHandSliceCheck.Run(ItemHandSliceCheck.SampleData());
    }
}
