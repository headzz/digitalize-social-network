﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalizeSocialNetwork.DomainModel.Entities;

namespace DigitalizeSocialNetwork.DomainModel.Specifications.ProfileSpecs
{
    public abstract class ProfileEntityValidation
    {
        public static bool IsValid(Profile profile)
        {
            return true;
        }
    }
}
