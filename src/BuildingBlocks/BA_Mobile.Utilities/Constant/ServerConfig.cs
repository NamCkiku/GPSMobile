using BA_Mobile.Utilities.Enums;
using BA_Mobile.Utilities.Extensions;

namespace BA_Mobile.Utilities.Constant
{
    /// <summary>
    /// Thông tin cấu hình của server
    /// Tất cả thông tin cấu hình cho vào đây để không bị loãng
    /// </summary>
    /// <Modified>
    /// Name     Date         Comments
    /// Namth  16/1/2018   created
    /// </Modified>
    public class ServerConfig
    {
        /// <summary>
        /// Đường dẫn API ở đâu
        /// Mặc định là:        ApiEndpointTypes.Server20
        /// Khi chạy thật là:   ApiEndpointTypes.ServerThat
        /// </summary>
        /// <Modified>
        /// Name     Date         Comments
        /// Namth  16/1/2018   created
        /// </Modified>
        public static ApiEndpointTypes ApiEndpointTypes = ApiEndpointTypes.ServerTest;

        public static ApiVehicleOnlineEndpointTypes ApiVehicleOnlineEndpointTypes = ApiVehicleOnlineEndpointTypes.ServerTest;

        /// <summary>
        /// IP của Service API
        /// </summary>
        /// <Modified>
        /// Name     Date         Comments
        /// Namth  16/1/2018   created
        /// </Modified>
        public static string ApiEndpoint
        {
            get
            {
                switch (ApiEndpointTypes)
                {
                    case ApiEndpointTypes.ServerThat:
                        return ApiEndpointTypes.ServerThat.ToDescription();

                    case ApiEndpointTypes.ServerTest:
                        return ApiEndpointTypes.ServerTest.ToDescription();

                    default:
                        return ApiEndpointTypes.ServerTest.ToDescription();
                }
            }
        }

        public static string ApiVehicleOnlineEndpoint
        {
            get
            {
                switch (ApiVehicleOnlineEndpointTypes)
                {
                    case ApiVehicleOnlineEndpointTypes.ServerThat:
                        return ApiVehicleOnlineEndpointTypes.ServerThat.ToDescription();

                    case ApiVehicleOnlineEndpointTypes.ServerTest:
                        return ApiVehicleOnlineEndpointTypes.ServerTest.ToDescription();

                    default:
                        return ApiVehicleOnlineEndpointTypes.ServerTest.ToDescription();
                }
            }
        }
    }
}