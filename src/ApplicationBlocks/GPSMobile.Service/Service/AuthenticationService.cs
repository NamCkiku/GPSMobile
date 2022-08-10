using BA_Mobile.Service;
using BA_Mobile.Utilities.Constant;
using GPSMobile.Entities.RequestEntity;
using GPSMobile.Entities.ResponeEntity;
using GPSMobile.Service.IService;
using System.Diagnostics;

namespace GPSMobile.Service.Service
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IRequestProvider _IRequestProvider;

        public AuthenticationService(IRequestProvider IRequestProvider)
        {
            _IRequestProvider = IRequestProvider;
        }

        public async Task<LoginResponse> Login(LoginRequest request)
        {
            LoginResponse user = new LoginResponse();
            try
            {
                var result = await _IRequestProvider.PostAsync<LoginRequest, ResponseBase<LoginResponse>>(ApiUri.POST_LOGIN, request);
                if (result != null && result.data != null)
                {
                    user = result.data;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Login-error:{ex.Message}");
            }
            return user;
        }
    }
}