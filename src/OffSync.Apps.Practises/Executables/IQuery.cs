namespace OffSync.Apps.Practises.Executables
{
    public interface IQuery<in TModel, out TResult>
    {
        TResult Execute(TModel model);
    }
}
