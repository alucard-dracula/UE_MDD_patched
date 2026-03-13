// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

[SupportedPlatforms(UnrealPlatformClass.Server)]
public class UnrealServerTarget : TargetRules
{
    public UnrealServerTarget(TargetInfo Target) : base(Target)
	{
		if (Target.Configuration == UnrealTargetConfiguration.Debug)
		{
			GlobalDefinitions.Add("_DEBUG=1");
			bDebugBuildsActuallyUseDebugCRT = true;
		}

		Type = TargetType.Server;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		BuildEnvironment = TargetBuildEnvironment.Shared;
		ExtraModuleNames.Add("UnrealGame");
	}
}
