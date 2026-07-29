// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Scammed : ModuleRules
{
	public Scammed(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Scammed",
			"Scammed/Variant_Platforming",
			"Scammed/Variant_Platforming/Animation",
			"Scammed/Variant_Combat",
			"Scammed/Variant_Combat/AI",
			"Scammed/Variant_Combat/Animation",
			"Scammed/Variant_Combat/Gameplay",
			"Scammed/Variant_Combat/Interfaces",
			"Scammed/Variant_Combat/UI",
			"Scammed/Variant_SideScrolling",
			"Scammed/Variant_SideScrolling/AI",
			"Scammed/Variant_SideScrolling/Gameplay",
			"Scammed/Variant_SideScrolling/Interfaces",
			"Scammed/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
