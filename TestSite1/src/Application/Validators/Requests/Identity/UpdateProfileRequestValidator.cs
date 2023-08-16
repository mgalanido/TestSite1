﻿using FluentValidation;
using Microsoft.Extensions.Localization;
using TestSite1.Application.Requests.Identity;

namespace TestSite1.Application.Validators.Requests.Identity
{
    public class UpdateProfileRequestValidator : AbstractValidator<UpdateProfileRequest>
    {
        public UpdateProfileRequestValidator(IStringLocalizer<UpdateProfileRequestValidator> localizer)
        {
            RuleFor(request => request.FirstName)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["First Name is required"]);
            RuleFor(request => request.LastName)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Last Name is required"]);
        }
    }
}