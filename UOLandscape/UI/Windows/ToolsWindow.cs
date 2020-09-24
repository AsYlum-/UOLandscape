﻿using ImGuiNET;

namespace UOLandscape.UI.Windows
{
    internal sealed class ToolsWindow : IToolsWindow
    {
        private bool _isActive;

        public bool IsVisible => _isActive;

        public ToolsWindow()
        {
            _isActive = true;
        }

        public void Hide()
        {
            _isActive = false;
        }

        public void ToggleVisibility()
        {
            _isActive = !_isActive;
        }

        public bool Show(uint dockSpaceId)
        {
            ImGui.SetNextWindowSize(new System.Numerics.Vector2(100, 450));

            if( ImGui.Begin("Tools", ref _isActive, ImGuiWindowFlags.NoResize) )
            {
                ImGui.End();
                return true;
            }

            return false;
        }
    }
}