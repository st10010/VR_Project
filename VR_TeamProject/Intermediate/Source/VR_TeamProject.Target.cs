using UnrealBuildTool;

public class VR_TeamProjectTarget : TargetRules
{
	public VR_TeamProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("VR_TeamProject");
	}
}
