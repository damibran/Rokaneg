using Godot;
using System;

public class end_restart : MarginContainer
{
    [Export]
    private NodePath end_menu_root_node_path;
    private Control end_menu_root_node;
    [Export]
    private NodePath main_menu_root_node_path;
    private Control main_menu_root_node;
    [Export]
    private NodePath game_root_node_path;
    private Control game_root_node;
    public override void _Ready()
    {
        end_menu_root_node = GetNode<Control>(end_menu_root_node_path);
        main_menu_root_node = GetNode<Control>(main_menu_root_node_path);
        game_root_node = GetNode<Control>(game_root_node_path);
    }
    public override void _Process(float delta)
    {

    }
    public void _on_quit_to_main_menu_button_pressed()
    {
        end_menu_root_node.Visible = false;
        main_menu_root_node.Visible = true;
    }
    public void _on_restart_button_pressed()
    {
        end_menu_root_node.Visible = false;
        game_root_node.Visible = true;
<<<<<<< HEAD

=======
>>>>>>> e5ebf53d46802782889d12fe88b54aaba0142c4d
    }
}
