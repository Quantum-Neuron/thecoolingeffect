using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace thecoolingeffect_api.Models
{
  /// <summary>
  /// About Details Model Class
  /// </summary>
  public class AboutDetail
  {
    public AboutDetail()
    {
      AboutDetailId = ObjectId.GenerateNewId().ToString();
    }

    /// <summary>
    /// Gets or sets the about details id.
    /// </summary>
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string AboutDetailId { get; set; }

    /// <summary>
    /// Gets or sets the joke
    /// </summary>
    [StringLength(200)]
    [BsonElement("Joke")]
    public string? Joke { get; set; }

    /// <summary>
    /// Gets or sets the first name.
    /// </summary>
    [StringLength(150)]
    [BsonElement("FirstName")]
    public string? FirstName { get; set; }

    /// <summary>
    /// Gets or sets the last name.
    /// </summary>
    [StringLength(150)]
    [BsonElement("LastName")]
    public string? LastName { get; set; }
  }
}
