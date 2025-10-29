using System;
using Sellorio.Sui.Services;

namespace Sellorio.Sui.Internal;

public interface IDisableStateScope : IDisposable
{
    IDialogProvider DialogProvider { get; }
    bool IsDisabled { get; }

    event Action IsDisabledChanged;
}