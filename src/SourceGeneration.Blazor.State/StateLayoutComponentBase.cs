using Microsoft.AspNetCore.Components;

namespace SourceGeneration.Blazor;

public abstract class StateLayoutComponentBase : StateComponentBase
{
    public StateLayoutComponentBase() { }

    [Parameter] public RenderFragment? Body { get; set; }
}
