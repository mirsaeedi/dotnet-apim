﻿using Apim.DevOps.Toolkit.ApimEntities.Subscription;
using Apim.DevOps.Toolkit.Core.DeploymentDefinitions.Entities;
using AutoMapper;

namespace Apim.DevOps.Toolkit.Core.Mapping
{
	public class SubscriptionMapper: IMapper
	{
		public void Map(IMapperConfigurationExpression cfg)
		{
			cfg.CreateMap<SubscriptionDeploymentDefinition, SubscriptionProperties>();
		}
	}
}
