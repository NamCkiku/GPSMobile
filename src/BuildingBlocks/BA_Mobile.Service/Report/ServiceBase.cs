namespace BA_Mobile.Service.Report
{
    public class ServiceBase<TInputModel, TEntity>
        where TInputModel : class, new()
        where TEntity : class, new()
    {
        private IRequestProvider requestProvider = null;

        protected IRequestProvider RequestProvider
        {
            get
            {
                if (requestProvider == null)
                {
                    requestProvider = new RequestProvider();
                }
                return requestProvider;
            }
        }

        public ServiceBase()
        {
        }

        public virtual Task<IList<TEntity>> GetData(TInputModel input)
        {
            return null;
        }
    }
}