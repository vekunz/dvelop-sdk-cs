﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using Dvelop.Sdk.IdentityProvider.Client;

namespace Dvelop.Sdk.IdentityProvider.Middleware
{
    public class IdentityProviderOptions
    {
        public Func<TenantInformation> TenantInformationCallback { get; set; }
        public bool AllowExternalValidation { get; set; } = false;
        public bool UseMinimizedOnlyIdValidateDetailLevel { get; set; } = false;
        public bool AllowAppSessions { get; set; } = true;
        public bool AllowImpersonatedUsers { get; set; } = true;
        public List<string> AllowedImpersonatedApps { get; set; } = new List<string>();
        public Action<IdentityProviderClientLogLevel, string> LogCallBack { get; set; }
        public HttpClient HttpClient { get; set; } = new HttpClient();
        public Uri BaseAddress { get; set; } = new Uri("http://localhost");
    }
}