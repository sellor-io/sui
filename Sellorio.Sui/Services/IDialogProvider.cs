using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Sellorio.Results;
using Sellorio.Sui.Dialogs;

namespace Sellorio.Sui.Services;

public interface IDialogProvider
{
    Task<ValueResult<TResult>> ShowDialogAsync<TResult>(Expression<Func<SuiDialogBase<TResult>>> expression);
    Task<Result> ShowDialogAsync(Expression<Func<SuiDialogBase>> expression);
}
