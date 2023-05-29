using System;
using Application.Helpers;
using Application.Messaging;
using Application.Services;

namespace Application.Features.CompanyFeatures.Commands.UpdateCompany
{
    public class UpdateCompanyCommandHandler : ICommandHandler<UpdateCompanyCommand, UpdateCompanyCommandResponse>
    {
        private readonly ICompanyService _companyService;

        public UpdateCompanyCommandHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        public async Task<UpdateCompanyCommandResponse> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
            byte[] logoBytes = FileService.FileConvertByteArrayToDatabase(request.Logo);
            string logoBase64 = "data:image/jpeg;base64," + Convert.ToBase64String(logoBytes);
            var company = await _companyService.GetById(Guid.Parse(request.Id),false);
            if(company != null)
            {
                company.CompanyName = request.CompanyName;
                company.Address1 = request.Address1;
                company.Address2 = request.Address2;
                company.City = request.City;
                company.Country = request.Country;
                company.Logo = logoBase64;
                await _companyService.UpdateAsync(company, cancellationToken);
                return new();
            } else
            {
                return new(false, "Şirket güncellenirken hata ile karşılaşılmıştır");
            }         
        }
    }
}

