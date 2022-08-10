using System.ComponentModel;

namespace BA_Mobile.Utilities.Enums
{
    public enum ApiEndpointTypes
    {
        [Description("http://apitaxi.bagroup.vn")]
        ServerThat,

        [Description("http://125.212.192.175:6000")]
        ServerTest,
    }

    public enum ApiVehicleOnlineEndpointTypes
    {
        [Description("http://vehicletaxi.bagroup.vn")]
        ServerThat,

        [Description("http://125.212.192.175:6002")]
        ServerTest,
    }
}