﻿using Apim.DevOps.Toolkit.ArmTemplates;
using Apim.DevOps.Toolkit.Core.DeploymentDefinitions;
using Apim.DevOps.Toolkit.Core.DeploymentDefinitions.Entities;
using Apim.DevOps.Toolkit.Core.Infrastructure.Constants;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Apim.DevOps.Toolkit.Core.ArmTemplates.ResourceCreators
{
	public class CertificateResourceCreator : IResourceCreator
	{
		private IMapper _mapper;

		public CertificateResourceCreator(IMapper mapper)
		{
			_mapper = mapper;
		}
		public IEnumerable<ArmTemplateResource> Create(DeploymentDefinition deploymentDefinition)
		{
			if (deploymentDefinition.Certificates.Count() == 0)
			{
				return Array.Empty<ArmTemplateResource>();
			}

			Console.WriteLine("Creating certificates template");
			Console.WriteLine("------------------------------------------");

			return new ArmTemplateResourceCreator<CertificateDeploymentDefinition, CertificateProperties>(_mapper)
				.ForDeploymentDefinitions(deploymentDefinition.Certificates)
				.WithName(d => d.Name)
				.OfType(ResourceType.Certificate)
				.CreateResources();
		}
	}
}
