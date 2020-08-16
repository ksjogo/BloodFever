using Godot;
using System;

public class Loading : Base
{
    public override void _Ready()
    {
        GetNode<Timer>("Timer").Start();
    }

    public void OnTimerTimeout()
    {
        switchTo("res://scenes/menu/Menu.tscn");
    }
}