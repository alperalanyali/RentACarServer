using System;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class Language:Entity
	{
		public string LanguageCode { get; set; }
		public string LanguageName { get; set; }
		public bool IsActive { get; set; }

		public Language()
		{

		}
		public Language(string languageCode,string languageName,bool isActive)
		{
			Id = Guid.NewGuid();
			LanguageCode = languageCode;
			LanguageName = languageName;
			IsActive = isActive;
		}
	}
}

