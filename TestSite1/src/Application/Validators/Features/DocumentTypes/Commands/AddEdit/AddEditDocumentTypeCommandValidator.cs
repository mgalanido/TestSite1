﻿using FluentValidation;
using Microsoft.Extensions.Localization;
using TestSite1.Application.Features.DocumentTypes.Commands.AddEdit;

namespace TestSite1.Application.Validators.Features.DocumentTypes.Commands.AddEdit
{
    public class AddEditDocumentTypeCommandValidator : AbstractValidator<AddEditDocumentTypeCommand>
    {
        public AddEditDocumentTypeCommandValidator(IStringLocalizer<AddEditDocumentTypeCommandValidator> localizer)
        {
            RuleFor(request => request.Name)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Name is required!"]);
            RuleFor(request => request.Description)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Description is required!"]);
        }
    }
}