namespace IntegrationTemplate;

public record ClientInvoice(
    string Label,
    decimal Amount,
    DateTime DueDate,
    string BillNumber,
    string Client);