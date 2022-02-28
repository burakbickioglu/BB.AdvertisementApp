using System;
using System.Security.Cryptography.X509Certificates;
using BB.AdvertisementApp.UI.Models;
using FluentValidation;

namespace BB.AdvertisementApp.UI.ValidationRules
{
    public class UserCreateModelValidator : AbstractValidator<UserCreateModel>
    {
        public UserCreateModelValidator()
        {
            //CascadeMode = CascadeMode.Stop;
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.Password).MinimumLength(3);
            RuleFor(x => x.Password).Equal(x => x.ConfirmPassword).WithMessage("Parolalar eşleşmiyor");
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.Surname).NotEmpty();
            RuleFor(x => x.UserName).NotEmpty();
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Kullanıcı adı minimum 3 karakter olmalıdır");

            RuleFor(x => new
            {
                x.UserName,
                x.FirstName
            }).Must(x => CanNotFirstName(x.UserName, x.FirstName)).WithMessage("Kullanıcı adı adınızı içeremez").
                When(x => x.UserName != null && x.FirstName != null);

            RuleFor(x => x.GenderId).NotEmpty();


        }

        private bool CanNotFirstName(string userName, string firstName)
        {
            return !userName.Contains(firstName);
        }

    }
}
