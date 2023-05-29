using System;
using Application.Messaging;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Application.Features.AuthFeatures.CreateUserCommand
{
	public class CreateUserCommmandHandler:ICommandHandler<CreateUserCommmand,CreateUserCommmandResponse>
	{
		private readonly UserManager<User> _userManager;
		public CreateUserCommmandHandler(UserManager<User>  userManager)
		{
			_userManager = userManager;
		}

        public async Task<CreateUserCommmandResponse> Handle(CreateUserCommmand request, CancellationToken cancellationToken)
        {
			var user = await _userManager.CreateAsync(new User()
			{
				UserName = request.UserName,
				Email = request.Email,
				FullName = request.FullName,
				Id = Guid.NewGuid()
			},request.Password);
			var response = new CreateUserCommmandResponse();
			if (user != null)
				response.IsSuccess = true;
			else
			{
				response.IsSuccess = false;
				response.Message = "Kullanıcı oluştururken bir hata ile karşılaşıld!!";
			}

			return response;
        }
    }
}

