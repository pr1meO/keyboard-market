﻿using FluentValidation;
using ProductService.API.Contracts.Brands;

namespace ProductService.API.Validators.Brands;

public class CreateBrandRequestValidator : AbstractValidator<CreateBrandRequest>
{
    private const int MIN_LENGTH = 4;
    private const int MAX_LENGTH = 30;

    public CreateBrandRequestValidator()
    {
        RuleFor(b => b.Name)
            .Length(MIN_LENGTH, MAX_LENGTH)
            .WithMessage($"Name length from {MIN_LENGTH} to {MAX_LENGTH} characters.");
    }
}
