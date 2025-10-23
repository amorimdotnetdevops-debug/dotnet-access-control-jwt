using Prontuario.Domain.Common.Exceptions;

namespace Prontuario.Domain.Common.Validations
{
    internal static class Guard
    {
        public static void AgainstEmptyGuid(Guid value, string parameterName)
        {
            if (value == Guid.Empty)
            {
                throw new DomainException($"O parâmetro '{parameterName}' não pode ser um GUID vazio.");
            }
        }

        public static void AgainstNull<T>(T value, string parameterName)
        {
            if (value == null)
            {
                throw new DomainException($"O parâmetro '{parameterName}' não pode ser nulo.");
            }
        }

        public static void Against<TException>(bool condition, string message) where TException : Exception
        {
            if (condition)
            {
                var exception = (TException)Activator.CreateInstance(typeof(TException), message)!;
                throw exception;
            }
        }
    }
}
