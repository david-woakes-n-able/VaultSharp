﻿using System.Threading.Tasks;
using VaultSharp.Infrastructure.Validation;

namespace VaultSharp.Backends.Auth.Token
{
    internal class TokenAuthProvider : IAuthProvider
    {
        private readonly TokenAuthInfo tokenAuthInfo;

        public TokenAuthProvider(TokenAuthInfo tokenAuthInfo)
        {
            Checker.NotNull(tokenAuthInfo, "tokenAuthInfo");
            Checker.NotNull(tokenAuthInfo.VaultToken, "tokenAuthInfo.VaultToken");

            this.tokenAuthInfo = tokenAuthInfo;
        }

        public async Task<string> GetVaultTokenAsync()
        {
            return await Task.FromResult(tokenAuthInfo.VaultToken);
        }
    }
}