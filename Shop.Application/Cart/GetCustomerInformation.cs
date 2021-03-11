﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Cart
{
    public class GetCustomerInformation
    {
        private ISession _sesstion;

        public GetCustomerInformation(ISession session)
        {
            _sesstion = session;
        }

        public class Request
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }

            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string City { get; set; }
            public string PostCode { get; set; }
        }

        public Request Do()
        {
            string stringObject = _sesstion.GetString("customer-info");

            if (string.IsNullOrEmpty(stringObject))
                return null;

            var response = JsonConvert.DeserializeObject<Request>(stringObject);
            return response;
        }
    }
}