using UnrealBuildTool;

public class TemplateProject2Target : TargetRules
{
	public TemplateProject2Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("TemplateProject2");
	}
}
