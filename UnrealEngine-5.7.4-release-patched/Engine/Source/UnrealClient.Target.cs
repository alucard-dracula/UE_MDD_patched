// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class UnrealClientTarget : TargetRules
{
    public UnrealClientTarget(TargetInfo Target) : base(Target)
	{
		if (Target.Configuration == UnrealTargetConfiguration.Debug)
		{
			GlobalDefinitions.Add("_DEBUG=1");
			bDebugBuildsActuallyUseDebugCRT = true;
		}

		Type = TargetType.Client;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		BuildEnvironment = TargetBuildEnvironment.Shared;
		ExtraModuleNames.Add("UnrealGame");
	}
}
