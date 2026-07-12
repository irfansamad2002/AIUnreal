// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class AIUnreal : ModuleRules
{
	public AIUnreal(ReadOnlyTargetRules Target) : base(Target)
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
			"AIUnreal",
			"AIUnreal/Variant_Platforming",
			"AIUnreal/Variant_Platforming/Animation",
			"AIUnreal/Variant_Combat",
			"AIUnreal/Variant_Combat/AI",
			"AIUnreal/Variant_Combat/Animation",
			"AIUnreal/Variant_Combat/Gameplay",
			"AIUnreal/Variant_Combat/Interfaces",
			"AIUnreal/Variant_Combat/UI",
			"AIUnreal/Variant_SideScrolling",
			"AIUnreal/Variant_SideScrolling/AI",
			"AIUnreal/Variant_SideScrolling/Gameplay",
			"AIUnreal/Variant_SideScrolling/Interfaces",
			"AIUnreal/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
