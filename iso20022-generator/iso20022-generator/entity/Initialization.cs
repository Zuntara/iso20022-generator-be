namespace OkiOki.Iso20022.Generator.Entity;

internal record Initialization
{
    public decimal ControlSum { get; set; }

    public bool AutoCalculateControlSum { get; set; }

    public string ContactDetailsName { get; set; } = "ISO20022-Generator / OkiOki";

    public string? ContactDetailsOther { get; set; }

    /// <summary>
    /// This must be a unique string identifier over all sent pain.001 files over the last 90 days.
    /// Your financial institute will use that id for duplicate checking. The id must not be longer than 34 characters
    /// </summary>
    public string UniqueDocumentId { get; set; } = Guid.NewGuid().ToString().Substring(0, 34);  // Must be unique for the bank within 90 days
}