// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class UnrealEditorTarget : TargetRules
{
	public UnrealEditorTarget( TargetInfo Target ) : base(Target)
	{
		if (Target.Configuration == UnrealTargetConfiguration.Debug)
		{
			GlobalDefinitions.Add("_DEBUG=1");
			bDebugBuildsActuallyUseDebugCRT = true;
		}

		Type = TargetType.Editor;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		BuildEnvironment = TargetBuildEnvironment.Shared;
		bBuildAllModules = true;
		ExtraModuleNames.Add("UnrealGame");
	}
}
