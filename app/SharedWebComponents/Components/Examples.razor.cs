// Copyright (c) Microsoft. All rights reserved.

namespace SharedWebComponents.Components;

public sealed partial class Examples
{
    [Parameter, EditorRequired] public required string Message { get; set; }
    [Parameter, EditorRequired] public EventCallback<string> OnExampleClicked { get; set; }

    private string WhatIsIncluded { get; } = "Har en forbruger ret til at ophæve aftalen?";
    private string WhatIsPerfReview { get; } = "Hvad sker der ved tvister?";
    private string WhatDoesPmDo { get; } = "Hvilken rolle spiller Voldgiftsnævnet?";

    private async Task OnClickedAsync(string exampleText)
    {
        if (OnExampleClicked.HasDelegate)
        {
            await OnExampleClicked.InvokeAsync(exampleText);
        }
    }
}
