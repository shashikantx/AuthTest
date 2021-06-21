using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AuthTest.Server.ViewModels.Authorization
{
    public class LogoutViewModel
    {
        [BindNever]
        public string RequestId { get; set; }
    }
}