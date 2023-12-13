namespace IntegrationTemplate;

public record SupplierInvoice(
    string Label,
    decimal Amount,
    DateTime DueDate,
    string BillNumber,
    string Supplier);