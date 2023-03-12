using System.Collections.Immutable;

namespace SmartHome.Expenses.Domain;

public sealed class Notification
{
    private readonly IList<string> _errors;
    private readonly object? _data;

    public IReadOnlyCollection<string> Errors => _errors.ToImmutableList();

    private Notification()
    {
        this._errors = new List<string>();
    }

    public Notification(object? data, string? error = null)
        : this()
    {
        this._data = data;

        this.AddError(error);
    }

    public TData? GetData<TData>() where TData : class
    {
        return (TData)this._data;
    }

    public Notification AddError(string? error)
    {
        if (string.IsNullOrEmpty(error)) return this;

        this._errors.Add(error);
        return this;
    }
}