namespace BillerMachineIntegration;

public interface IBillerMachineAPI
{
    Task<string> CallGetInvoicesEndpoint();
}