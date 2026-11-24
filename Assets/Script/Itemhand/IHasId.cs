/// <summary>
/// DataTableSearch で検索できるデータが持つ「IDを持つ」という約束。
/// </summary>
public interface IHasId
{
    string Id { get; }
}