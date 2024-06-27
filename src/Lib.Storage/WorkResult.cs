namespace Semantica.Storage;

public record WorkResult
{
    public bool Success { get; init; }
    
    public string? Message { get; init; }
    
    public int? AffectedId { get; init; }
}