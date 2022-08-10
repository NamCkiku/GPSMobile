namespace BA_Mobile.Service.IService
{
    public interface IReportBaseService<TRequest, TResponse> where TRequest : class, new() where TResponse : class, new()
    {
        TRequest Request { get; set; }

        Task<TResponse> GetData();

        Task<TResponse> GetMoreData();

        Task<int> GetCount();
    }
}