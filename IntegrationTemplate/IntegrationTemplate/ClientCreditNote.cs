namespace IntegrationTemplate;

public record ClientCreditNote(
    string Label,
    decimal Amount,
    DateTime DueDate,
    string? AttachedBillNumber,
    string Client);