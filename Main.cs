using Godot;
using Godot.Collections;
using System;

public partial class Main : Node2D
{
    private Label la;
    private Timer times;
    private int  Couts = 0;
    private bool[] duis = new bool[4];
    public override void _Ready()
    {
        for(int i=0;i<4;i++)
        {
            duis[i] = true;
        }
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
    public void duiss(int i)
    {
        duis[i] = true;
    }
    private void clickButton()
    {

        for(int i=0;i<4;i++){
            
            if(!duis[i]){
                continue;
            }else{
                PackedScene newScene = GD.Load<PackedScene>("res://Mission.tscn");
                Node nodes = newScene.Instantiate();
                Button buts = nodes.GetNode<Button>("Button");
                this.GetTree().CurrentScene.AddChild(nodes);
                nodes.Call("SetMess",i);
                buts.Position = new Vector2(120,100+130*i); 
                duis[i] = false;
                break;
            }
        }
       
    }

    private void sorts()
    {
        for(int i=0;i<4;i++)
        {
            var Childs = GetChild<Button>;
        }
    }
}