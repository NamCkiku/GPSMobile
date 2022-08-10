namespace BA_Mobile.Core.Resources
{
    public class CommonResource
    {
        public static string Common_ConnectInternet_Error => MobileResource.Get("Kết nối mạng không ổn định", "No internet");

        public static string Common_Lable_Car => MobileResource.Get("Xe", "Car");

        public static string Common_Label_Vehicle => MobileResource.Get("Phương tiện", "Vehicle");

        public static string Common_Lable_KmUnit => MobileResource.Get("km/h", "km/h");

        public static string Common_Lable_NotFound => MobileResource.Get("Không tìm thấy dữ liệu..", "Not found...");

        public static string Common_Message_Processing => MobileResource.Get("Đang xử lý...", "Processing...");

        public static string Common_Label_Notification => MobileResource.Get("Thông báo", "Notification");

        public static string Common_Message_Warning => MobileResource.Get("Cảnh báo", "Warning");

        public static string Common_Button_OK => MobileResource.Get("Đồng ý", "OK");
        public static string Common_Message_NoDataJoinDay => MobileResource.Get("Chưa có dữ liệu tìm kiếm", "Data not found");

        public static string Common_Button_Send => MobileResource.Get("Gửi", "Send");
        public static string Common_Button_View => MobileResource.Get("Xem", "View");
        public static string Common_Button_Save => MobileResource.Get("Lưu", "Save");
        public static string Common_Button_Cancel => MobileResource.Get("Hủy", "Cancel");
        public static string Common_Button_Yes => MobileResource.Get("Có", "Yes");
        public static string Common_Button_No => MobileResource.Get("Không", "No");
        public static string Common_Button_Close => MobileResource.Get("Đóng", "Close");
        public static string Common_Message_ErrorTryAgain => MobileResource.Get("Có lỗi xảy ra, vui lòng thử lại", "Error(s), please try again");

        public static string Common_Message_SearchText => MobileResource.Get("Tìm kiếm", "Search");
        public static string Common_Message_PlaceholderSearchText => MobileResource.Get("Tìm kiếm tính năng", "Search feature");

        public static string Common_Button_Update => MobileResource.Get("Cập nhật", "Update");

        public static string Common_Button_Update_Later => MobileResource.Get("Cập nhật sau", "Update Later");

        public static string Common_Message_Skip => MobileResource.Get("Bỏ qua", "Skip");

        public static string Common_Message_NotPermission => MobileResource.Get("Chức năng chưa được cấp quyền", "Function has not been granted");

        #region datetime picker

        public static string Common_Label_TimePicker => MobileResource.Get("Chọn Giờ", "Time Picker");
        public static string Common_Label_DatePicker => MobileResource.Get("Chọn Ngày", "Date Picker");
        public static string Common_Label_Chose => MobileResource.Get("Chọn", "Chose");
        public static string Common_Label_DateTimePicker => MobileResource.Get("Chọn Ngày Giờ", "Date Time Picker");
        public static string Common_Label_Year => MobileResource.Get("Năm", "Year");
        public static string Common_Label_Month => MobileResource.Get("Tháng", "Month");
        public static string Common_Label_Day => MobileResource.Get("ngày", "day");
        public static string Common_Label_DayUpper => MobileResource.Get("Ngày", "Day");
        public static string Common_Label_Days => MobileResource.Get("ngày", "days");
        public static string Common_Label_Day2 => MobileResource.Get("N", "D");
        public static string Common_Label_Hour => MobileResource.Get("Giờ", "hour");
        public static string Common_Label_Hours => MobileResource.Get("giờ", "hours");
        public static string Common_Label_Hour2 => MobileResource.Get("G", "H");
        public static string Common_Label_Minute => MobileResource.Get("Phút", "minute");
        public static string Common_Label_Minutes => MobileResource.Get("phút", "minutes");
        public static string Common_Label_Minute2 => MobileResource.Get("P", "M");
        public static string Common_Label_Second => MobileResource.Get("giây", "second");
        public static string Common_Label_Duration => MobileResource.Get("Thời gian", "Duration");
        public static string Common_Label_Duration2 => MobileResource.Get("T.Gian", "Dur");

        #endregion datetime picker

        public static string Common_Label_Male => MobileResource.Get("Nam", "Male");

        public static string Common_Label_Female => MobileResource.Get("Nữ", "Female");

        public static string Common_Label_Other => MobileResource.Get("Khác", "Other");

        public static string Common_Label_HighLight => MobileResource.Get("YÊU THÍCH", "FAVORITES");

        public static string Common_Label_VehiclePlate => MobileResource.Get("Biển kiểm soát", "Vehicle plate");

        public static string Common_Message_NoData => MobileResource.Get("Không có dữ liệu trong khoảng thời gian tìm kiếm", "Data not found");

        public static string Common_Message_NotFindYourCar => MobileResource.Get("Không tìm thấy xe của bạn", "Did not find your car");

        public static string Common_Message_ErrorFromDateBiggerToDate => MobileResource.Get("Ngày bắt đầu lớn hơn ngày kết thúc", "The start date is greater than the end date");
        public static string Common_Message_ErrorTimeFromToTimeEnd => MobileResource.Get("Giờ bắt đầu lớn hơn giờ kết thúc", "The start time is greater than the end time");

        public static string Common_Message_ErrorIsNotRuleFromDate => MobileResource.Get("Ngày bắt đầu không hợp lệ", "Invalid start date");
        public static string Common_Message_ErrorIsNotRuleToDate => MobileResource.Get("Ngày kết thúc không hợp lệ", "Invalid end date");
        public static string Common_Message_ErrorIsNullFromDate => MobileResource.Get("Ngày bắt đầu không được để trống", "Start date cannot be blank");
        public static string Common_Message_ErrorIsNullToDate => MobileResource.Get("Ngày kết thúc không được để trống", "End date cannot be left blank");

        public static string Common_Message_NoSelectVehiclePlate => MobileResource.Get("Bạn phải chọn ít nhất 1 biển số xe", "Please input at least 1 vehicleplate");

        public static string Common_Message_ErrorOverDateSearch => MobileResource.Get("Hệ thống chỉ hỗ trợ tìm kiếm trong khoảng {0} ngày", "You only get the search details < {0} days ");
    }
}