namespace OffSync.Apps.Practises.Executables
{
    public interface ICommand<in TModel>
    {
        void Execute(TModel model);
    }

    public interface ICommand<in TModel, out TResult>
    {
        TResult Execute(TModel model);
    }
}
