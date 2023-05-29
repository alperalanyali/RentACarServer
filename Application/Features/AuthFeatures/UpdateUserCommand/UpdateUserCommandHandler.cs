using System;
using Application.Messaging;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Application.Features.AuthFeatures.UpdateUserCommand
{
    public class UpdateUserCommandHandler : ICommandHandler<UpdateUserCommand, UpdateUserCommandResponse>
    {
        private readonly UserManager<User> _userManager;
        public UpdateUserCommandHandler(UserManager<User> userManager)
        {
            _userManager = userManager;
        }


        public async Task<UpdateUserCommandResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {

            var user = await _userManager.FindByIdAsync(request.Id.ToString());
            user.UserName = request.Username;
            user.Email = request.Email;
            user.FullName = request.FullName;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, request.Password);
            await _userManager.UpdateAsync(user);

            return new();
        }
    }
}

