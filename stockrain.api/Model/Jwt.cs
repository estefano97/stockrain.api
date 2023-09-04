namespace stockrain.api.Model;

public class Jwt
{
    public string Key { get; set; }
    public string Issuser { get; set; }
    public string Audience { get; set; }
    public string Subject { get; set; }
}