using UnrealBuildTool;

public class SurfaceTrailsTarget : TargetRules
{
	public SurfaceTrailsTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("SurfaceTrails");
	}
}
