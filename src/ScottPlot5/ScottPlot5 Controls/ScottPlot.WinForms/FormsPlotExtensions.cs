﻿using System.Windows.Forms;
using ScottPlot.Control;

namespace ScottPlot.WinForms;

internal static class FormsPlotExtensions
{
    internal static Pixel Pixel(this MouseEventArgs e)
    {
        return new Pixel(e.X, e.Y);
    }

    internal static Control.MouseButton Button(this MouseEventArgs e)
    {
        return e.Button switch
        {
            System.Windows.Forms.MouseButtons.Left => Control.MouseButton.Left,
            System.Windows.Forms.MouseButtons.Right => Control.MouseButton.Right,
            System.Windows.Forms.MouseButtons.Middle => Control.MouseButton.Middle,
            _ => Control.MouseButton.Unknown,
        };
    }

    internal static Key Key(this KeyEventArgs e)
    {
        return e.KeyCode switch
        {
            Keys.ControlKey => Control.Key.Ctrl,
            Keys.Menu => Control.Key.Alt,
            Keys.ShiftKey => Control.Key.Shift,
            _ => Control.Key.Unknown,
        };
    }
}
