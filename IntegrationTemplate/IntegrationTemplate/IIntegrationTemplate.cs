namespace IntegrationTemplate;
public interface IIntegrationTemplate
{
    Task<IReadOnlyCollection<SupplierInvoice>> FetchSupplierInvoices();
    
    Task<IReadOnlyCollection<ClientInvoice>> FetchClientInvoices();
    
    Task<IReadOnlyCollection<SupplierCreditNote>> FetchSupplierCreditNotes();
    
    Task<IReadOnlyCollection<ClientCreditNote>> FetchClientCreditNotes();
}
