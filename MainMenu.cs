using Godot;
using System;

public class MainMenu : MarginContainer
{

    [Export]
    private NodePath menu_root_node_path;
    private Control menu_root_node;

    private 

    public override void _Ready()
    {
        menu_root_node = GetNode<Control>(menu_root_node_path);
    }
    public override void _Process(float delta)
    {
        
    }
    public void _on_endless_level_button_pressed()
    {
        menu_root_node.Visible = false;
        
    }
}
