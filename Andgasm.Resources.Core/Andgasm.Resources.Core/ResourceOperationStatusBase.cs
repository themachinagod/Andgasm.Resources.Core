using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Andgasm.Resources.Core
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public interface IResourceOperationStatusBase
    {
        string CanBeDeletedMessage { get; set; }
        List<AssociatedDeleteStatus> AssociatedDeleteStatuses { get; set; }
        List<UneditableField> UneditableFields { get; set; }
        bool CanBeDeleted { get; }
    }

    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ResourceOperationStatusBase : IResourceOperationStatusBase
    {
        public string CanBeDeletedMessage { get; set; }

        public List<AssociatedDeleteStatus> AssociatedDeleteStatuses { get; set; }
        public List<UneditableField> UneditableFields { get; set; }

        public bool CanBeDeleted
        {
            get
            {
                return string.IsNullOrWhiteSpace(CanBeDeletedMessage);
            }
        }
    }
}
