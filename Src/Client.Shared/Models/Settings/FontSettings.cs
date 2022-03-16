namespace Client.Shared.Models.Settings;

public class FontSettings
{
    public IEnumerable<string> FontFamily { get; set; } //TODO make this valueobject
    public string FontSize { get; set; } //TODO make this valueobject
    public string LineHeight { get; set; } //TODO make this valueobject
}