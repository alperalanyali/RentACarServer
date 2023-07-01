using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.UserCompanyFeatures.Commands.UpdateUserCompany
{
    public class UpdateUserCompanyCommandHandler : ICommandHandler<UpdateUserCompanyCommand, UpdateUserCompanyCommandResponse>
    {
        private readonly IUserCompanyService _userCompanyService;
        public UpdateUserCompanyCommandHandler(IUserCompanyService userCompanyService)
        {
            _userCompanyService = userCompanyService;
        }
        public async Task<UpdateUserCompanyCommandResponse> Handle(UpdateUserCompanyCommand request, CancellationToken cancellationToken)
        {
            var userCompany = await _userCompanyService.GetById(request.Id);
            var response = new UpdateUserCompanyCommandResponse();
            if(userCompany != null)
            {
                userCompany.UserId = request.UserId;
                userCompany.CompanyId = request.CompanyId;

                await _userCompanyService.UpdateAsync(userCompany, cancellationToken);
            }else
            {
                response = new UpdateUserCompanyCommandResponse("Böyle bir kayıt bulunmaktadır");
            }
            return response;
        }
    }
}

