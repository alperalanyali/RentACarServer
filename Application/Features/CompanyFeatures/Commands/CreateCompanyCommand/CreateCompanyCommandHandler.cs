using System;
using Application.Helpers;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.CompanyFeatures.Commands.CreateCompanyCommand
{
    public class CreateCompanyCommandHandler : ICommandHandler<CreateCompanyCommand, CreateCompanyCommandResponse>
    {
        private readonly ICompanyService _companyService;


        public CreateCompanyCommandHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<CreateCompanyCommandResponse> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            //var logoByte = FileService.FileConvertByteArrayToDatabase(request.Logo);
            //string logoBase64 = "data:image/jpeg;base64,"+Convert.ToBase64String(logoByte);

            var company = new Company(request.CompanyName, request.Address1, request.Address2, request.City, request.Country, request.TaxNumber, request.Logo);

            await _companyService.CreateAsync(company, cancellationToken);

            return new();
        }
    }
}

