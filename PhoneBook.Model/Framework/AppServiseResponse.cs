﻿namespace PhoneBook.Model.Framework;

public class AppServiseResponse
{
    private readonly List<string> _errors = new();
    public bool IsSuccess => !IsFailur;
    public bool IsFailur => _errors.Any();

    public void AddError(string errorMessage)
    {
        _errors.Add(errorMessage);
    }

    public IReadOnlyList<string> Errors => _errors;
}
public class AppServiseResponse<TResult>: AppServiseResponse
{
    public TResult Result { get; set; }
}