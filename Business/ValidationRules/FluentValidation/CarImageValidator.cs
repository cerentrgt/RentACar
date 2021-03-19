using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator:AbstractValidator<CarImagesDto>
    {
        public CarImageValidator()
        {

            RuleFor(x => x.ImageFile).NotNull();

            RuleFor(x => x.ImageFile.Length).LessThanOrEqualTo(1024 * 1024)
                    .WithMessage("Dosya boyutu en fazla 3MB olmalıdır.");

            RuleFor(x => x.ImageFile.ContentType).NotNull().Must(x => x.Equals("image/jpeg") || x.Equals("image/jpg") || x.Equals("image/png"))
                    .WithMessage("Dosya türü desteklenmiyor!");
        }
    }
}
