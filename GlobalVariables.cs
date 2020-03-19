using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace DAISY_6
{
    public static class GlobalVariables
    {

        // GLOBALIZE THIS HTTP-CLIENT OBJECT (STATIC HTTP-CLIENT OBJECT) FOR THE APPLICATION 
        // SO WE DONT RUN OUT OF SOCKETS WHEN UNDER HEAVY LOADS!

        public static HttpClient WebApiClient = new HttpClient() 
        { BaseAddress = new Uri("https://localhost:44305/") };
       

        // Constructor Object 
        //GlobalVariables() 
        //{

            //WebApiClient.BaseAddress = new Uri("https://localhost:44305/");

            //WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //}



    }
}