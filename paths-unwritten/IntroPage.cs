
using Godot;

public partial class IntroPage : Control
{
	private void OnStartButtonPressed()
	{
		GetTree().ChangeSceneToFile("res://StoryPage.tscn");
	}
}
