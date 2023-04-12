﻿using System.Reactive;
using Avalonia.Controls;
using ReactiveUI;

namespace AvaloniaGUI.ViewModels;

public class CircuitDesignerViewModel:ViewModelBase
{
    // for key bindings
    public ReactiveCommand<Unit, Unit> Cut { get; }
    public ReactiveCommand<Unit, Unit> Copy { get; }
    public ReactiveCommand<Unit, Unit> Paste { get; }
    public ReactiveCommand<Unit, Unit> Delete { get; }
    
    public ReactiveCommand<Unit,Unit> CompositeTool_Checked { get; }
    
    public CircuitGridViewModel CircuitGrid { get; set; }
}