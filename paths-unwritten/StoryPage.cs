using Godot;

public partial class StoryPage : Control
{
	public override void _Ready()
	{
		GetNode<Button>("BadChoiceButton").Pressed += OnBadChoicePressed;
		GetNode<Button>("GoodChoiceButton").Pressed += OnGoodChoicePressed;
	}

	private void OnBadChoicePressed()
	{
		GetTree().ChangeSceneToFile("res://bad_ending.tscn");
	}

	private void OnGoodChoicePressed()
	{
		GetTree().ChangeSceneToFile("res://GoodEnding.tscn");
	}
}
