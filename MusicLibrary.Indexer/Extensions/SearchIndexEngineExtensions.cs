using MusicLibrary.Indexer.Engine;
using MusicLibrary.Indexer.Models.Base;
using MusicLibrary.Indexer.Models.Internal;
using System.Linq.Expressions;

namespace MusicLibrary.Indexer.Extensions;

public static class SearchIndexEngineExtensions
{
    public static string GetFieldName<T>(this ISearchIndexEngine<T> engine, Expression<Func<T, string>> expr) where T : IDocument
    {
        if (expr.Body is not MemberExpression memberExpression)
            throw new ArgumentException($"The provided expression contains a {expr.GetType().Name} which is not supported. Only simple member accessors (fields, properties) of an object are supported.");

        return GetFieldName(engine, memberExpression.Member.Name);
    }

    public static string GetFieldName<T>(this ISearchIndexEngine<T> engine, Expression<Func<T, int>> expr) where T : IDocument
    {
        if (expr.Body is not MemberExpression memberExpression)
            throw new ArgumentException($"The provided expression contains a {expr.GetType().Name} which is not supported. Only simple member accessors (fields, properties) of an object are supported.");

        return GetFieldName(engine, memberExpression.Member.Name);
    }

    public static string GetFieldName<T>(this ISearchIndexEngine<T> engine, Expression<Func<T, DateTime>> expr) where T : IDocument
    {
        if (expr.Body is not MemberExpression memberExpression)
            throw new ArgumentException($"The provided expression contains a {expr.GetType().Name} which is not supported. Only simple member accessors (fields, properties) of an object are supported.");

        return GetFieldName(engine, memberExpression.Member.Name);
    }

    private static string GetFieldName<T>(ISearchIndexEngine<T> engine, string fieldName) where T : IDocument
    {
        if (DocumentFields<T>.Fields is null || DocumentFields<T>.Fields.Count.Equals(0))
            ArgumentNullException.ThrowIfNull(DocumentFields<T>.Fields);

        if (!DocumentFields<T>.Fields.ContainsKey(fieldName))
            throw new ArgumentException($"The provided property doesn't exists: {fieldName}.");

        return DocumentFields<T>.Fields[fieldName].FieldName;
    }
}
