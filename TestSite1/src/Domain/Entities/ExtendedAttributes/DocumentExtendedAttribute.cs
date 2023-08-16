using TestSite1.Domain.Contracts;
using TestSite1.Domain.Entities.Misc;

namespace TestSite1.Domain.Entities.ExtendedAttributes
{
    public class DocumentExtendedAttribute : AuditableEntityExtendedAttribute<int, int, Document>
    {
    }
}