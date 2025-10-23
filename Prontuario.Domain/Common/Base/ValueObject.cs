
namespace Prontuario.Domain.Common.Base
{
    public abstract class ValueObject
    {
        // Métodoque deve ser implementado nas classes filhas para retornar 
        // todos os atributos que definem a igualdade estrutural do objeto.
        protected abstract IEnumerable<object> GetEqualityComponents();

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != GetType()) return false;

            var other = (ValueObject)obj;
            return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
        }

        public override int GetHashCode()
        {
            // Combina os códigos hash de todos os componentes de igualdade
            return GetEqualityComponents()
                .Select(obj => obj?.GetHashCode() ?? 0)
                .Aggregate((x, y) => x ^ y);
        }
    }
}
