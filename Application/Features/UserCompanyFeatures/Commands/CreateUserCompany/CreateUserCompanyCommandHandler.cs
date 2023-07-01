using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.UserCompanyFeatures.Commands.CreateUserCompany
{
    public class CreateUserCompanyCommandHandler : ICommandHandler<CreateUserCompanyCommand, CreateUserCompanyCommandResponse>
    {
        private readonly IUserCompanyService _userCompanyService;
        public CreateUserCompanyCommandHandler(IUserCompanyService userCompanyService)
        {
            _userCompanyService = userCompanyService;
        }
        public async Task<CreateUserCompanyCommandResponse> Handle(CreateUserCompanyCommand request, CancellationToken cancellationToken)
        {
            var userCompany = new UserCompany(request.UserId, request.CompanyId);
            await _userCompanyService.CreateAsync(userCompany, cancellationToken);

            return new("Kullanıcı şirket başarılı şekilde atanmıştır");
        }
    }
}

