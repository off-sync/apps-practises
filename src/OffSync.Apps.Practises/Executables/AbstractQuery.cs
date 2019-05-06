using OffSync.Apps.Practises.Validation;

namespace OffSync.Apps.Practises.Executables
{
    public abstract class AbstractQuery<TModel, TResult> :
        IQuery<TModel, TResult>
    {
        public TResult Execute(
            TModel model)
        {
            ExecutePreConditions(model);

            var result = InternalExecute(model);

            ExecutePostConditions(result);

            return result;
        }

        protected abstract TResult InternalExecute(TModel model);

        protected virtual void ExecutePreConditions(
            TModel model)
        {
            ValidationUtil.Validate(model);
        }

        protected virtual void ExecutePostConditions(
            TResult result)
        {
            ValidationUtil.Validate(result);
        }
    }
}
