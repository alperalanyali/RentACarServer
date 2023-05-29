using System;
namespace Application.Features.AuthFeatures.CreateUserCommand
{
	public sealed class CreateUserCommmandResponse {
		public bool IsSuccess { get; set; } = false;

		public string Message { get; set; } = "Kullanıcı kayıt işlemi başarılı şekilde gerçekleştirmiştir";
		};

}

