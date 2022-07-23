using System.Xml.Serialization;

var serializer = new XmlSerializer(typeof(Map));
var map = serializer.Deserialize(new StreamReader(@"level1.tmx"));

;

[XmlRoot("map")]
public class Map
{
    [XmlElement("layer")]
    public Layer[]? Layers { get; set; }
    
    [XmlElement("tileset")]
    public TileSet? TileSet { get; set; }

    [XmlAttribute("tiledversion")]
    public string? TiledVersion { get; set; }

    [XmlAttribute("orientation")]
    public string? Orientation { get; set; }
    
    [XmlAttribute("renderorder")]
    public string? RenderOrder { get; set; }
    
    [XmlAttribute("width")]
    public string? Width { get; set; }
    
    [XmlAttribute("height")]
    public string? Height { get; set; }
    
    [XmlAttribute("tilewidth")]
    public string? TileWidth { get; set; }    
    
    [XmlAttribute("tileheight")]
    public string? TileHeight { get; set; }
}

[XmlRoot("layer")]
public class Layer
{
    [XmlAttribute("id")]
    public string? Id { get; set; }
    
    [XmlAttribute("name")]
    public string? Name { get; set; }
    
    [XmlAttribute("width")]
    public string? Width { get; set; }

    [XmlAttribute("height")]
    public string? Height { get; set; }

    [XmlElement("data")]
    public string? Data { get; set; }
}

[XmlRoot("tileset")]
public class TileSet
{
    [XmlAttribute("firstgid")]    
    public string? FirstGid { get; set; }

    [XmlAttribute("source")]
    public string? Source { get; set; }
}

[XmlRoot("group")]
public class Group
{
    
}

