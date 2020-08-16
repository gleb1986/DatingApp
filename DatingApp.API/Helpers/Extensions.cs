using System;
using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message){
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-control-Allow-Origins", "*");
        }

        public static int CalculateAge(this DateTime theDateTime){
            var age = DateTime.Today.Year - theDateTime.Year;
            if (theDateTime.Date < DateTime.Today.Date)
            {
                return age - 1;
            }
            return age;
        }
    }
}