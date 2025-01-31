using Godot;
using System;

public partial class Mission1 : Node2D
{
	[Export]
	public int mess;
	// Called when the node enters the scene tree for the first time.
	public delegate void getMess(int messb);
	public override void _Ready()
	{

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	public void SetMess(int messb)
	{
		this.mess=  messb; 
	}
	
	public void loses()
	{
		var nodes = this.GetParent();
		nodes.Call("duiss",mess);
		this.QueueFree();
	}
}
