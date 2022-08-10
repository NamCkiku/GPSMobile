namespace BA_Mobile.Utilities.Constant
{
    public class ApiUri
    {
        #region authorization

        public const string POST_LOGIN = "api/v1/authentication/login";
        public const string POST_CHANGE_PASSWORD = "api/v1/authentication/changepassword";

        #endregion authorization

        #region vehicle

        public const string GET_VEHICLEONLINE = "api/v1/vehicleonline/getlistvehicleonline";

        public const string GET_VEHICLEONLINESYNC = "api/v1/vehicleonline/syncvehicleonline";

        public const string GET_VEHICLE_COMPANY = "api/v1/vehicles/getlistcompanyid";

        public const string GET_VEHICLE_GROUP = "api/v1/vehicles/getlistgroups";

        #endregion vehicle
        #region vehicledebtmoney

        public const string GET_LISTVEHICLEDEBTMONEY = "api/v1/vehicles/getlistexpired";
        public const string GET_COUNTVEHICLEDEBTMONEY = "api/v1/vehicles/countexpired";
        public const string GET_LISTVEHICLEFREE = "api/v1/vehicles/getallvehiclefree";

        #endregion vehicledebtmoney

        #region Vehicle detail

        public const string GET_VEHICLEDETAIL = "api/v1/vehicleonline/getvehicledetail";

        // public const string GET_ADDRESSESBYLATLNG = "api/geocode/batchaddress";

        #endregion Vehicle detail

        #region Menu

        public const string GET_HOME_MENU = "api/v1/menu/getmenubyculture";

        #endregion Menu

        #region Setting

        public const string USER_SET_SETTINGS = "api/v1/mobileusersetting/updatemobileusersetting";

        public const string MOBILE_GET_SETTINGS = "api/v1/mobile/getconfig";

        public const string MOBILE_GET_VERSION = "api/v1/mobile/getbyos";

        #endregion Setting

        #region Address

        public const string GET_GETADDRESSBYLATLNG = "api/v1/geocode/getaddress";

        #endregion Address

        #region AppDevice

        public const string INSERT_UPDATE_APP_DEVICE = "api/v1/appdevice/insertupdateappdevice";

        public const string GET_TIMESERVER = "api/v1/ping/timeserver";

        #endregion AppDevice

        #region ALERT

        public const string GET_ALERT_ONLINE = "api/v1/alert/getalert";

        public const string GET_COUNT_ALERT_ONLINE = "api/v1/alert/getcountalert";

        public const string GET_ALERT_TYPE = "api/v1/alert/getalerttypebycompanyid";

        public const string POST_ALERT_HANDLE = "api/v1/alert/handlealert";

        public const string GET_ALERT_USER_CONFIGURATIONS = "api/v1/alert/getalertuserconfigurationbyuserid";

        public const string SEND_ALERT_USER_CONFIG = "api/v1/alert/insertorupdateuseralertconfig";
        public const string GET_ALERT_MASK_DETAIL = "api/v1/alert/getalertmaskdetail";

        #endregion ALERT

        #region User

        public const string GET_USERINFOMATION = "api/v1/user/getuserinfor";
        public const string GET_USERBYUSERNAME = "api/v1/authentication/getuserinfobyusername";
        public const string USER_UPDATE_AVATAR = "api/v1/upload/uploadimagebase64";
        public const string USER_UPDATE_INFO = "api/v1/user/updateuserinfor";
        public const string ADMIN_USER_SET_SETTINGS = "api/v1/user/userconfiguration";

        #endregion User

        public const string POST_ROUTE = "api/v1/route/getroutehistory";


        #region Category

        public const string CATEGORY_LIST = "api/v1/menu/getcategorybyname";

        #endregion Category


        #region Report
        public const string GETWARNINGREPORT = "api/v1/reports/warningreport";

        public const string GETREPORTTRIPBYVEHICLE = "api/v1/reports/tripbyvehiclereport";

        public const string GETLISTREPORTTRIPDETAILBYVEHICLE = "api/v1/reports/tripdetailbyvehiclereport";

        public const string GETREPORTACTIVITYSUMMARY = "api/v1/reports/activitysummaries";

        #endregion
    }
}