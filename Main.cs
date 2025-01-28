using Godot;
using Godot.Collections;
using System;

public partial class Main : Node2D
{
	private double time = 0;
	// Called when the node enters the scene tree for the first time.
	private Label la;
	Dictionary dates = Time.GetDatetimeDictFromSystem();
	public override void _Ready()
	{
		 la = GetNode<Label>("/root/main/Label");

		// Timer times = GetNode<Timer>("Timer") ;
		// times.Start();

		// var currentTime = Time.GetDateDictFromSystem();
        // GD.Print("当前时间: " + currentTime);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Dictionary dates = Time.GetDatetimeDictFromSystem();
		String s1 = (String)dates["hour"];
		String s2 = (String)dates["minute"];
		String s3 = (String)dates["second"];
		String ss = s1+'/'+s2+'/'+s3;
		la.Text= ss;
	}
}
