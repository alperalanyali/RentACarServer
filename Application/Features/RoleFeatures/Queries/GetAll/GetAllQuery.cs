﻿using System;
using Application.Messaging;

namespace Application.Features.RoleFeatures.Queries.GetAll
{
	public sealed record GetAllQuery(string search) : IQuery<GetAllQueryResponse>;
	
}

