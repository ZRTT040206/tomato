using Godot;
using Godot.Collections;
using System;

public partial class Main : Node2D
{
    private Label la;
    private Timer times;

    public override void _Ready()
    {
        la = GetNode<Label>("/root/main/Label");
		times = new Timer(); 
		this.AddChild(times);
        times.WaitTime = 1.0f; // 设置定时器每秒触发一次
        times.Connect("timeout", new Callable(this, "hhh"));
        times.Start(); // 启动定时器
    }

    public override void _Process(double delta)
    {
        // 这里可以添加其他逻辑，如果需要的话
    }

    private void hhh()
    {
        // 获取当前时间
        Dictionary dates = Time.GetDatetimeDictFromSystem();
        String s1 = (String)dates["hour"]; // 使用安全转换
        String s2 = (String)dates["minute"];
        String s3 = (String)dates["second"];
        String ss = s1 + ':' + s2 + ':' + s3;
        la.Text = ss; // 更新Label文本
    }
    private void clickButton()
    {
        PackedScene newScene = GD.Load<PackedScene>("res://Mission.tscn");
        Node nodes = newScene.Instantiate();
        this.GetTree().CurrentScene.AddChild(nodes);
    }
}