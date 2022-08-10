using GPSMobile.Entities.RequestEntity;
using GPSMobile.Entities.ResponeEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSMobile.Service.IService
{
    public interface IAuthenticationService
    {
        Task<LoginResponse> Login(LoginRequest request);
    }
}
