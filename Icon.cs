using Godot;
using System;

public partial class Icon : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	int i = 42;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
    float AMOUNT = 5;
    if (Input.IsKeyPressed((Key.W))) {
      this.Position += new Godot.Vector2(0,-AMOUNT);
    }
    if (Input.IsKeyPressed((Key.S))) {
      this.Position += new Godot.Vector2(0,AMOUNT);
    }
    if (Input.IsKeyPressed((Key.A))) {
      this.Position += new Godot.Vector2(-AMOUNT,0);
    }
    if (Input.IsKeyPressed((Key.D))) {
      this.Position += new Godot.Vector2(AMOUNT, 0);
    }
	}
}
