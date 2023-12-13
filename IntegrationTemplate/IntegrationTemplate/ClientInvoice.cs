namespace IntegrationTemplate;

public record ClientInvoice(
    string Label,
    decimal Price,
    DateTime DueDate,
    string BillNumber,
    string Client);