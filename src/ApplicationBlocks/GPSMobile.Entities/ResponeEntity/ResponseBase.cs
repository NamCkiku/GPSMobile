using BA_Mobile.Entities.Enums;

namespace GPSMobile.Entities.ResponeEntity
{
    public class ResponseBase<T>
    {
        public T data { get; set; }

        public int statusCode { set; get; }

        public ResponseCodeEnums responseCode { set; get; }

        public string userMessage { set; get; }

        public string internalMessage { get; set; }
    }
}