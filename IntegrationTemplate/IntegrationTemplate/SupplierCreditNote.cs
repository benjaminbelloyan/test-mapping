namespace IntegrationTemplate;

public record SupplierCreditNote(
    string Label,
    decimal Amount,
    DateTime DueDate,
    string? AttachedBillNumber,
    string Supplier);