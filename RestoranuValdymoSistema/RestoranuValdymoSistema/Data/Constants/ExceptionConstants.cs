namespace RestoranuValdymoSistema.Data.Constants;

public static class ExceptionConstants
{
    public static string NotFound<TType>(Guid id) => $"{typeof(TType).Name} with ID {id} not found";
    public static string NotFound<TType>() => $"{typeof(TType).Name} not found";
    public static string InvalidRole => $"Invalid role";

}