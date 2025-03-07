namespace Ab5tmBleReader.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
