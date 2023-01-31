namespace CoreLayer.Utilities.Results.Abstract;
public interface IResult
{
    public bool IsSuccess { get; }
    public string? Message { get; }
}
