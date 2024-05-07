namespace Prototype
{
    public class ServerConfiguration : IPrototype
    {
        public string FileStorageURL { get; set; }
        public string OperationSystem { get; set; }
        public string DBConnect { get; set; }

        public object Clone()
        {
            var clone = new ServerConfiguration
            {
                FileStorageURL = this.FileStorageURL,
                OperationSystem = this.OperationSystem,
                DBConnect = "This private connection string is not cloned."
            };
            return clone;
        }

        public string GetDetails()
        {
            return $"FileStorageURL: {FileStorageURL}, OperationSystem: {OperationSystem}, DBConnect: {DBConnect}";
        }
    }
}