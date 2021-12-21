namespace Maya.Raynet.Crm.Model
{
    public class RaynetApiOption
    {
        public string Endpoint { get; set; } = "https://app.raynet.cz/api/v2";

        public string InstanceName { get; set; }

        public string UserName { get; set; }

        public string ApiKey { get; set; }
    }
}
