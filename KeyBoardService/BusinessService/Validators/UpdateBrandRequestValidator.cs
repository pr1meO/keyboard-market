﻿using BusinessService.Contracts.Brands;
using FluentValidation;

namespace BusinessService.Validators
{
    public class UpdateBrandRequestValidator : AbstractValidator<UpdateBrandRequest>
    {
        private const int MIN_LENGTH = 4;
        private const int MAX_LENGTH = 30;

        public UpdateBrandRequestValidator()
        {
            RuleFor(b => b.Name)
                .Length(MIN_LENGTH, MAX_LENGTH)
                .WithMessage($"Name length from {MIN_LENGTH} to {MAX_LENGTH} characters.");
        }
    }
}
