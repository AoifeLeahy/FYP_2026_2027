using Godot;

public partial class BadEnding : Control
{
	public override void _Ready()
	{
		GetNode<Button>("ReadAgainButton").Pressed += OnReadAgainPressed;
	}

	private void OnReadAgainPressed()
	{
		GetTree().ChangeSceneToFile("res://StoryPage.tscn");
	}
}
