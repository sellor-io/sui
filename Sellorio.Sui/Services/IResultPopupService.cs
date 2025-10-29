using System.Threading.Tasks;
using Sellorio.Results;

namespace Sellorio.Sui.Services;

public interface IResultPopupService
{
    Task ShowResultAsPopupAsync(IResult result, string? successMessage);
}
