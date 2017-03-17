﻿using System.Threading.Tasks;
using JsonRPC;
using Lsp.Models;
// ReSharper disable CheckNamespace

namespace Lsp.Protocol
{
    public static class RegisterCapabilityExtensions
    {
        public static Task RegisterCapability(this IClient mediator,  RegistrationParams @params)
        {
            return mediator.SendRequest("client/registerCapability", @params);
        }
    }
}