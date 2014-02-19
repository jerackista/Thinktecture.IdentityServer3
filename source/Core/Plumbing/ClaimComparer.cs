﻿using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Thinktecture.IdentityServer.Core.Plumbing
{
    class ClaimComparer : IEqualityComparer<Claim>
    {
        public bool Equals(Claim x, Claim y)
        {
            return (x.Type == y.Type &&
                    x.Value == y.Value);
        }

        public int GetHashCode(Claim claim)
        {
            if (Object.ReferenceEquals(claim, null)) return 0;

            int typeHash = claim.Type == null ? 0 : claim.Type.GetHashCode();
            int valueHash = claim.Value == null ? 0 : claim.Value.GetHashCode();

            return typeHash ^ valueHash;
        }
    }
}