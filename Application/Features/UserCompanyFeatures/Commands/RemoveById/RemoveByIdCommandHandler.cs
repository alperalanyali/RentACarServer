using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.UserCompanyFeatures.Commands.RemoveById
{
    public class RemoveByIdCommandHandler : ICommandHandler<RemoveByIdCommand, RemoveByIdCommandResponse>
    {
        private readonly IUserCompanyService _userCompanyService;

        public RemoveByIdCommandHandler(IUserCompanyService userCompanyService)
        {
            _userCompanyService = userCompanyService;
        }
        public async Task<RemoveByIdCommandResponse> Handle(RemoveByIdCommand request, CancellationToken cancellationToken)
        {
            var userCompany = await _userCompanyService.GetById(request.Id);
            var response = new RemoveByIdCommandResponse("Böyle bir kayıt yoktur");
            if(userCompany != null)
            {
                await _userCompanyService.RemoveUserCompany(request.Id, cancellationToken);
                response = new RemoveByIdCommandResponse("Kayıt başarılı şekilde silinmiştir");
            }
                
            return response;
        }
    }
}

